using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asr.Data;
using Asr.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Asr.Controllers
{
    [Authorize(Roles = Constants.StudentRole)]
    public class StudentDash : Controller
    {
        private readonly AsrContext _context;

        public StudentDash(AsrContext context)
        {
            _context = context;
        }

        // GET all slots
        public async Task<IActionResult> Index()
        {
            var slots = from s in _context.Slot select s;
            return View(slots);
        }

        // Get all available slots (with no student booked in) 
        public async Task<IActionResult> AllSlots(int? page)
        {
            var slots = from s in _context.Slot where s.StudentID == null select s;
            int pageSize = 5;
            return View(await PaginatedList<Slot>.CreateAsync(slots, page ?? 1, pageSize));
        }

        // Get all slots with booked by the logged in user
        public async Task<IActionResult> AllBookings(int? page)
        {
            var slots = from s in _context.Slot
                        where s.StudentID == HttpContext.User.Identity.Name.Substring(0, 8)
                        select s;
            int pageSize = 5;
            return View(await PaginatedList<Slot>.CreateAsync(slots, page ?? 1, pageSize));
        }

        // GET details for a specific slot
        public async Task<IActionResult> Details(string roomid, DateTime starttime)
        {
            if (roomid == null)
            {
                return NotFound();
            }

            Slot slot = _context.Slot.Where(x => x.RoomID == roomid && x.StartTime == starttime).FirstOrDefault();
            if (slot == null)
            {
                return NotFound();
            }

            return View(slot);
        }

        // Retrieve slot from database to book
        public async Task<IActionResult> BookSlot(string roomid, DateTime starttime)
        {
            if (roomid == null)
            {
                return NotFound();
            }

            Slot slot = _context.Slot.Where(x => x.RoomID == roomid && x.StartTime == starttime).FirstOrDefault();
            if (slot == null)
            {
                return NotFound();
            }
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", slot.RoomID);
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "StaffID", slot.StaffID);
            ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID", slot.StudentID);
            return View(slot);
        }

        // Book slot setting studentid to the logged in user and save changes to the database 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookSlot(string roomid, DateTime starttime, [Bind("RoomID,StartTime,StaffID,StudentID")] Slot slot)
        {
            var studentid = HttpContext.User.Identity.Name.Substring(0, 8);

            if (roomid != slot.RoomID)
            {
                return NotFound();
            }

            if (_context.Slot.Where(x => x.StartTime.Date == starttime.Date && x.StudentID == studentid).Count() == 1)
            {
                ViewData["ErrorMessage"] = new string ("Failed to book slot. You already have a slot booked for this date.");
                return View(slot);
            }

            slot.StudentID = studentid;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlotExists(slot.RoomID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            await _context.SaveChangesAsync();
            return View(slot);
        }

        private bool SlotExists(string id)
        {
            return _context.Slot.Any(e => e.RoomID == id);
        }

        // Retrieve details for a booking to be cancelled 
        public async Task<IActionResult> CancelBooking(string roomid, DateTime starttime)
        {
            if (roomid == null)
            {
                return NotFound();
            }

            Slot slot = _context.Slot.Where(x => x.RoomID == roomid && x.StartTime == starttime).FirstOrDefault();
            if (slot == null)
            {
                return NotFound();
            }
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", slot.RoomID);
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "StaffID", slot.StaffID);
            ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", null, slot.StudentID);
            return View(slot);
        }

        // Cancels the booking for the logged in user by setting the slot studentid to null
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelBooking(string roomid, DateTime starttime, [Bind("RoomID,StartTime,StaffID,StudentID")] Slot slot)
        {
            if (roomid != slot.RoomID)
            {
                return NotFound();
            }
            slot.StudentID = null;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlotExists(slot.RoomID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", slot.RoomID);
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "StaffID", slot.StaffID);
            ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID", slot.StudentID);
            return View(slot);
        }
    }
}