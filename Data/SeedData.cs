using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Asr.Models;
using Microsoft.AspNetCore.Identity;

namespace Asr.Data
{
    public static class SeedData
    {
        public static async Task InitialiseAsync(IServiceProvider serviceProvider)
        {
            using (var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>())
            using (var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>())
            using (var context = new AsrContext(serviceProvider.GetRequiredService<DbContextOptions<AsrContext>>()))
            {
                await InitialiseUsersAsync(userManager, roleManager);
                await InitialiseAsrDataAsync(context, userManager);
            }
        }

        private static async Task InitialiseUsersAsync(
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            foreach (var role in new[] { Constants.StaffRole, Constants.StudentRole })
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole { Name = role });
            }

            await CreateUserAndEnsureUserHasRoleAsync(userManager, "e12345@rmit.edu.au", Constants.StaffRole);
            await CreateUserAndEnsureUserHasRoleAsync(userManager, "e56789@rmit.edu.au", Constants.StaffRole);
            await CreateUserAndEnsureUserHasRoleAsync(userManager, "s1234567@student.rmit.edu.au", Constants.StudentRole);
            await CreateUserAndEnsureUserHasRoleAsync(userManager, "s4567890@student.rmit.edu.au", Constants.StudentRole);
        }

        private static async Task CreateUserAndEnsureUserHasRoleAsync(
            UserManager<ApplicationUser> userManager, string userName, string role)
        {
            if (await userManager.FindByNameAsync(userName) == null)
                await userManager.CreateAsync(new ApplicationUser { UserName = userName, Email = userName }, "abc123");
            await EnsureUserHasRoleAsync(userManager, userName, role);
        }

        private static async Task EnsureUserHasRoleAsync(
            UserManager<ApplicationUser> userManager, string userName, string role)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user != null && !await userManager.IsInRoleAsync(user, role))
                await userManager.AddToRoleAsync(user, role);
        }

        private static async Task InitialiseAsrDataAsync(AsrContext context, UserManager<ApplicationUser> userManager)
        {
            // Look for any rooms.
            if (await context.Room.AnyAsync())
                return; // DB has been seeded.

            await context.Room.AddRangeAsync(
                new Room { RoomID = "A" },
                new Room { RoomID = "B" },
                new Room { RoomID = "C" },
                new Room { RoomID = "D" }
            );

            await CreateStaffAsync(context, "e12345", "Matt");
            await CreateStaffAsync(context, "e56789", "Matt");

            await CreateStudentAsync(context, "s1234567", "Kevin");
            await CreateStudentAsync(context, "s4567890", "Olivier");

            await context.Slot.AddRangeAsync(
                new Slot
                {
                    RoomID = "A",
                    StartTime = new DateTime(2019, 1, 30),
                    StaffID = "e12345"
                },
                new Slot
                {
                    RoomID = "B",
                    StartTime = new DateTime(2019, 1, 30),
                    StaffID = "e56789",
                    StudentID = "s1234567"
                }
            );

            await context.SaveChangesAsync();

            await UpdateUserAsync(userManager, "e12345@rmit.edu.au", "e12345");
            await UpdateUserAsync(userManager, "e56789@rmit.edu.au", "e56789");
            await UpdateUserAsync(userManager, "s1234567@student.rmit.edu.au", "s1234567");
            await UpdateUserAsync(userManager, "s4567890@student.rmit.edu.au", "s4567890");
        }

        private static async Task CreateStaffAsync(AsrContext context, string id, string name)
        {
            await context.Staff.AddAsync(new Staff
            {
                StaffID = id,
                Email = id + "@rmit.edu.au",
                Name = name
            });
        }

        private static async Task CreateStudentAsync(AsrContext context, string id, string name)
        {
            await context.Student.AddAsync(new Student
            {
                StudentID = id,
                Email = id + "@student.rmit.edu.au",
                Name = name
            });
        }

        private static async Task UpdateUserAsync(UserManager<ApplicationUser> userManager, string userName, string id)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user.UserName.StartsWith('e'))
                user.StaffID = id;
            if (user.UserName.StartsWith('s'))
                user.StudentID = id;

            await userManager.UpdateAsync(user);
        }
    }
}
