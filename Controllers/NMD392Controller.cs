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
    public class NMD392Controller : Controller
    {
        private readonly NguyenManhDucDBContext _context;

        public NMD392Controller(NguyenManhDucDBContext context)
        {
            _context = context;
        }

        // GET: NMD392
        public async Task<IActionResult> Index()
        {
            return View(await _context.NMD392.ToListAsync());
        }

        // GET: NMD392/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nMD392 = await _context.NMD392
                .FirstOrDefaultAsync(m => m.NMDID == id);
            if (nMD392 == null)
            {
                return NotFound();
            }

            return View(nMD392);
        }

        // GET: NMD392/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NMD392/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NMDID,NMDName,NMDGende")] NMD392 nMD392)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nMD392);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nMD392);
        }

        // GET: NMD392/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nMD392 = await _context.NMD392.FindAsync(id);
            if (nMD392 == null)
            {
                return NotFound();
            }
            return View(nMD392);
        }

        // POST: NMD392/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NMDID,NMDName,NMDGende")] NMD392 nMD392)
        {
            if (id != nMD392.NMDID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nMD392);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NMD392Exists(nMD392.NMDID))
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
            return View(nMD392);
        }

        // GET: NMD392/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nMD392 = await _context.NMD392
                .FirstOrDefaultAsync(m => m.NMDID == id);
            if (nMD392 == null)
            {
                return NotFound();
            }

            return View(nMD392);
        }

        // POST: NMD392/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nMD392 = await _context.NMD392.FindAsync(id);
            _context.NMD392.Remove(nMD392);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NMD392Exists(string id)
        {
            return _context.NMD392.Any(e => e.NMDID == id);
        }
    }
}
