using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DvhLesson10.Models;

namespace DvhLesson10.Controllers
{
    public class DvhCategroysController : Controller
    {
        private readonly DvhK23cnt2Lesson10Context _context;

        public DvhCategroysController(DvhK23cnt2Lesson10Context context)
        {
            _context = context;
        }

        // GET: DvhCategroys
        public async Task<IActionResult> DvhIndex()
        {
            return View(await _context.Categroys.ToListAsync());
        }

        // GET: DvhCategroys/Details/5
        public async Task<IActionResult> DvhDetails(int? dvhId)
        {
            if (dvhId == null)
            {
                return NotFound();
            }

            var categroy = await _context.Categroys
                .FirstOrDefaultAsync(m => m.CateId == dvhId);
            if (categroy == null)
            {
                return NotFound();
            }

            return View(categroy);
        }

        // GET: DvhCategroys/Create
        public IActionResult DvhCreate()
        {
            return View();
        }

        // POST: DvhCategroys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CateId,CateName,CateStatus")] Categroy categroy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categroy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DvhIndex));
            }
            return View(categroy);
        }

        // GET: DvhCategroys/Edit/5
        public async Task<IActionResult> DvhEdit(int? dvhid)
        {
            if (dvhid == null)
            {
                return NotFound();
            }

            var categroy = await _context.Categroys.FindAsync(dvhid);
            if (categroy == null)
            {
                return NotFound();
            }
            return View(categroy);
        }

        // POST: DvhCategroys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DvhEdit(int id, [Bind("CateId,CateName,CateStatus")] Categroy categroy)
        {
            if (id != categroy.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categroy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategroyExists(categroy.CateId))
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
            return View(categroy);
        }

        // GET: DvhCategroys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categroy = await _context.Categroys
                .FirstOrDefaultAsync(m => m.CateId == id);
            if (categroy == null)
            {
                return NotFound();
            }

            return View(categroy);
        }

        // POST: DvhCategroys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categroy = await _context.Categroys.FindAsync(id);
            if (categroy != null)
            {
                _context.Categroys.Remove(categroy);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategroyExists(int id)
        {
            return _context.Categroys.Any(e => e.CateId == id);
        }
    }
}
