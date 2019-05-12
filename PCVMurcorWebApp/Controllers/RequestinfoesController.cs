﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PCVMurcorWebApp.Models;

namespace PCVMurcorWebApp.Controllers
{
    public class RequestinfoesController : Controller
    {
        private readonly VirtotaSolutionsContext _context;

        public RequestinfoesController(VirtotaSolutionsContext context)
        {
            _context = context;
        }

        // GET: Requestinfoes
        public async Task<IActionResult> Index()
        {
            var virtotaSolutionsContext = _context.Requestinfo.Include(r => r.User);
            return View(await virtotaSolutionsContext.ToListAsync());
        }

        // GET: Requestinfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestinfo = await _context.Requestinfo
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (requestinfo == null)
            {
                return NotFound();
            }

            return View(requestinfo);
        }

        // GET: Requestinfoes/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId");
            return View();
        }

        // POST: Requestinfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TodayDate,RequestType,RequestByName,EffectiveStart,EffectiveEnd,UserId")] Requestinfo requestinfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestinfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId", requestinfo.UserId);
            return View(requestinfo);
        }

        // GET: Requestinfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestinfo = await _context.Requestinfo.FindAsync(id);
            if (requestinfo == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId", requestinfo.UserId);
            return View(requestinfo);
        }

        // POST: Requestinfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TodayDate,RequestType,RequestByName,EffectiveStart,EffectiveEnd,UserId")] Requestinfo requestinfo)
        {
            if (id != requestinfo.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requestinfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestinfoExists(requestinfo.UserId))
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
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId", requestinfo.UserId);
            return View(requestinfo);
        }

        // GET: Requestinfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestinfo = await _context.Requestinfo
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (requestinfo == null)
            {
                return NotFound();
            }

            return View(requestinfo);
        }

        // POST: Requestinfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requestinfo = await _context.Requestinfo.FindAsync(id);
            _context.Requestinfo.Remove(requestinfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestinfoExists(int id)
        {
            return _context.Requestinfo.Any(e => e.UserId == id);
        }
    }
}
