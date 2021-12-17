using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenManhDuc392.Models;

namespace NguyenManhDuc392.Controllers
{
    public class UniversityNMD392Controller : Controller
    {
        private readonly NguyenManhDucDBContext _context;

        public UniversityNMD392Controller(NguyenManhDucDBContext context)
        {
            _context = context;
        }

        // GET: UniversityNMD392
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityNMD392.ToListAsync());
        }

        // GET: UniversityNMD392/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNMD392 = await _context.UniversityNMD392
                .FirstOrDefaultAsync(m => m.UniversityID == id);
            if (universityNMD392 == null)
            {
                return NotFound();
            }

            return View(universityNMD392);
        }

        // GET: UniversityNMD392/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityNMD392/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityID,UniversityName")] UniversityNMD392 universityNMD392)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityNMD392);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityNMD392);
        }

        // GET: UniversityNMD392/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNMD392 = await _context.UniversityNMD392.FindAsync(id);
            if (universityNMD392 == null)
            {
                return NotFound();
            }
            return View(universityNMD392);
        }

        // POST: UniversityNMD392/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityID,UniversityName")] UniversityNMD392 universityNMD392)
        {
            if (id != universityNMD392.UniversityID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityNMD392);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityNMD392Exists(universityNMD392.UniversityID))
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
            return View(universityNMD392);
        }

        // GET: UniversityNMD392/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNMD392 = await _context.UniversityNMD392
                .FirstOrDefaultAsync(m => m.UniversityID == id);
            if (universityNMD392 == null)
            {
                return NotFound();
            }

            return View(universityNMD392);
        }

        // POST: UniversityNMD392/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityNMD392 = await _context.UniversityNMD392.FindAsync(id);
            _context.UniversityNMD392.Remove(universityNMD392);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityNMD392Exists(string id)
        {
            return _context.UniversityNMD392.Any(e => e.UniversityID == id);
        }
    }
}
