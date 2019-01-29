﻿using System;
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
    [Authorize(Roles = Constants.StaffRole)]
    public class StaffDash : Controller
    {
        private readonly AsrContext _context;

        public StaffDash(AsrContext context)
        {
            _context = context;
        }

        // GET: Slot
        public async Task<IActionResult> Index(int? page)
        {
            var staffid = HttpContext.User.Identity.Name.Substring(0, 6);
            var slots = from s in _context.Slot
                        where s.StaffID == staffid
                        orderby s.StartTime
                        select s;

            int pageSize = 5;
            return View(await PaginatedList<Slot>.CreateAsync(slots, page ?? 1, pageSize));
        }


        // GET: Slot/Details/5
        public async Task<IActionResult> Details(string roomid, DateTime starttime)
        {
            if (roomid == null)
            {
                return NotFound();
            }

            var slot = await _context.Slot
                .Include(s => s.Room)
                .Include(s => s.Staff)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.RoomID == roomid && m.StartTime == starttime);
            if (slot == null)
            {
                return NotFound();
            }

            return View(slot);
        }

        // GET: Slot/Create
        public IActionResult Create()
        {
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID");
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "StaffID");
            ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID");
            return View();
        }

        // POST: Slot/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomID,StartTime,StaffID,StudentID")] Slot slot)
        {
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", slot.RoomID);
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "StaffID", slot.StaffID);
            ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID", slot.StudentID);

            if (_context.Slot.Where(x => x.RoomID == slot.RoomID && x.StartTime.Date == slot.StartTime.Date).Count() == 2)
            {
                ViewData["DateMessage"] = new string($"Room {slot.RoomID} has exceeded the max amount of bookings for the selected date.");
                return View(slot);
            }

            if(_context.Slot.Where(x => x.StartTime.Date == slot.StartTime.Date && x.StaffID == slot.StaffID).Count() == 4)
            {
                ViewData["StaffMessage"] = new string($"You have exceeded the max amount of bookings for the selected date.");
                return View(slot);
            }

            if (!ValidTime(slot.StartTime))
            {
                ViewData["DateMessage"] = new string($"Invalid time selected.");
                return View(slot);
            }

            if (ModelState.IsValid)
            {
                _context.Add(slot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(slot);
        }

        // GET: Slot/Edit/5
        public async Task<IActionResult> Edit(string roomid, DateTime starttime)
        {
            if (roomid== null)
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

        // POST: Slot/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string roomid, DateTime starttime, [Bind("RoomID,StartTime,StaffID,StudentID")] Slot slot)
        {
            if (roomid != slot.RoomID)
            {
                return NotFound();
            }

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

        // GET: Slot/Delete/5
        public async Task<IActionResult> Delete(string roomid, DateTime starttime)
        {
            if (roomid == null)
            {
                return NotFound();
            }

            var slot = await _context.Slot
                .Include(s => s.Room)
                .Include(s => s.Staff)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.RoomID == roomid && m.StartTime == starttime);
            if (slot == null)
            {
                return NotFound();
            }

            return View(slot);
        }

        // POST: Slot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string roomid, DateTime starttime)
        {
            Slot slot = _context.Slot.Where(x => x.RoomID == roomid && x.StartTime == starttime).FirstOrDefault();
            _context.Slot.Remove(slot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlotExists(string id)
        {
            return _context.Slot.Any(e => e.RoomID == id);
        }

        public bool ValidTime(DateTime time)
        {
            return (time.Minute == 0 && time.Hour <= 14 && time.Hour >= 9 && time > DateTime.Now);
        }

    }
}
