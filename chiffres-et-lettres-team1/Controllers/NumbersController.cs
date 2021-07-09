using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using chiffres_et_lettres_team1.Data;

namespace chiffres_et_lettres_team1.Controllers
{
    public class NumbersController : Controller
    {
        private readonly chiffres_et_lettres_team1Context _context;

        public NumbersController(chiffres_et_lettres_team1Context context)
        {
            _context = context;
        }

        // GET: Numbers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Numbers.ToListAsync());
        }

        // GET: Numbers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var numbers = await _context.Numbers
                .FirstOrDefaultAsync(m => m.NumbersID == id);
            if (numbers == null)
            {
                return NotFound();
            }

            return View(numbers);
        }

        // GET: Numbers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Numbers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumbersID,Name")] Numbers numbers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(numbers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(numbers);
        }

        // GET: Numbers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var numbers = await _context.Numbers.FindAsync(id);
            if (numbers == null)
            {
                return NotFound();
            }
            return View(numbers);
        }

        // POST: Numbers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NumbersID,Name")] Numbers numbers)
        {
            if (id != numbers.NumbersID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(numbers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NumbersExists(numbers.NumbersID))
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
            return View(numbers);
        }

        // GET: Numbers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var numbers = await _context.Numbers
                .FirstOrDefaultAsync(m => m.NumbersID == id);
            if (numbers == null)
            {
                return NotFound();
            }

            return View(numbers);
        }

        // POST: Numbers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var numbers = await _context.Numbers.FindAsync(id);
            _context.Numbers.Remove(numbers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NumbersExists(int id)
        {
            return _context.Numbers.Any(e => e.NumbersID == id);
        }
    }
}
