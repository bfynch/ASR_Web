using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Asr.Data;
using Microsoft.AspNetCore.Authorization;
using Asr.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Asr.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly AsrContext _context;

        public RegisterModel(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger, AsrContext asrcontext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = asrcontext;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            [RegularExpression(@"^s\d{7}@student.rmit.edu.au|e\d{5}@rmit.edu.au$",
                ErrorMessage = "Email address is not in a valid format.")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public string Name { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {   
            
            returnUrl = returnUrl ?? Url.Content("~/");
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email };
                if (Input.Email.StartsWith('e'))
                {
                    user.StaffID = Input.Email.Substring(0, 6);
                    var staff = new Staff();
                    staff.StaffID = user.StaffID;
                    staff.Email = Input.Email;
                    staff.Name = Input.Name;
                    _context.Add(staff);
                    await _context.SaveChangesAsync();
                }
                if (Input.Email.StartsWith('s'))
                {
                    user.StudentID = Input.Email.Substring(0, 8);
                    var student = new Student();
                    student.StudentID = user.StudentID;
                    student.Email = Input.Email;
                    student.Name = Input.Name;
                    _context.Add(student);
                    await _context.SaveChangesAsync();
                }

                var result = await _userManager.CreateAsync(user, Input.Password);
                await _userManager.AddToRoleAsync(user, user.UserName.StartsWith('e') ? Constants.StaffRole :
                    user.UserName.StartsWith('s') ? Constants.StudentRole : throw new Exception());

                if(result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    await _signInManager.SignInAsync(user, false);

                    return LocalRedirect(returnUrl);
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
