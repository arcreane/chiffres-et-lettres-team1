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
    public class LettersController : Controller
    {
        private readonly chiffres_et_lettres_team1Context _context;

        public LettersController(chiffres_et_lettres_team1Context context)
        {
            _context = context;
        }

        // GET: Letters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Letters.ToListAsync());
        }

        // GET: Letters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var letters = await _context.Letters
                .FirstOrDefaultAsync(m => m.LettersID == id);
            if (letters == null)
            {
                return NotFound();
            }

            return View(letters);
        }

        // GET: Letters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Letters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LettersID,Name")] Letters letters)
        {
            if (ModelState.IsValid)
            {
                _context.Add(letters);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(letters);
        }

        // GET: Letters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var letters = await _context.Letters.FindAsync(id);
            if (letters == null)
            {
                return NotFound();
            }
            return View(letters);
        }

        // POST: Letters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LettersID,Name")] Letters letters)
        {
            if (id != letters.LettersID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(letters);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LettersExists(letters.LettersID))
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
            return View(letters);
        }

        // GET: Letters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var letters = await _context.Letters
                .FirstOrDefaultAsync(m => m.LettersID == id);
            if (letters == null)
            {
                return NotFound();
            }

            return View(letters);
        }

        // POST: Letters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var letters = await _context.Letters.FindAsync(id);
            _context.Letters.Remove(letters);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LettersExists(int id)
        {
            return _context.Letters.Any(e => e.LettersID == id);
        }
    }
}
