using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FetchMates.Models;

namespace FetchMates.Views
{
    public class DogParkVisitsController : Controller
    {
        private readonly FetchMatesDataContext _context;

        public DogParkVisitsController(FetchMatesDataContext context)
        {
            _context = context;
        }

        // GET: DogParkVisits
        public async Task<IActionResult> Index()
        {
            var fetchMatesDataContext = _context.DogParkVisits.Where(p => p.DayAndTime >= DateTime.Now);
            return View(await fetchMatesDataContext.ToListAsync());
        }

        // GET: DogParkVisits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogParkVisit = await _context.DogParkVisits
                .Include(d => d.Dog)
                .FirstOrDefaultAsync(m => m.VisitId == id);
            if (dogParkVisit == null)
            {
                return NotFound();
            }

            return View(dogParkVisit);
        }

        // GET: DogParkVisits/Create
        public IActionResult Create()
        {
            ViewData["DogId"] = new SelectList(_context.Dogs, "DogId", "DogName");
            return View();
        }

        // POST: DogParkVisits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisitId,DogId,ParkName,DayAndTime")] DogParkVisit dogParkVisit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dogParkVisit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DogId"] = new SelectList(_context.Dogs, "DogId", "DogName", dogParkVisit.DogId);
            return View(dogParkVisit);
        }

        // GET: DogParkVisits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogParkVisit = await _context.DogParkVisits.FindAsync(id);
            if (dogParkVisit == null)
            {
                return NotFound();
            }
            ViewData["DogId"] = new SelectList(_context.Dogs, "DogId", "DogName", dogParkVisit.DogId);
            return View(dogParkVisit);
        }

        // POST: DogParkVisits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VisitId,DogId,ParkName,DayAndTime")] DogParkVisit dogParkVisit)
        {
            if (id != dogParkVisit.VisitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dogParkVisit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogParkVisitExists(dogParkVisit.VisitId))
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
            ViewData["DogId"] = new SelectList(_context.Dogs, "DogId", "DogName", dogParkVisit.DogId);
            return View(dogParkVisit);
        }

        // GET: DogParkVisits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogParkVisit = await _context.DogParkVisits
                .Include(d => d.Dog)
                .FirstOrDefaultAsync(m => m.VisitId == id);
            if (dogParkVisit == null)
            {
                return NotFound();
            }

            return View(dogParkVisit);
        }

        // POST: DogParkVisits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dogParkVisit = await _context.DogParkVisits.FindAsync(id);
            _context.DogParkVisits.Remove(dogParkVisit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DogParkVisitExists(int id)
        {
            return _context.DogParkVisits.Any(e => e.VisitId == id);
        }
    }
}
