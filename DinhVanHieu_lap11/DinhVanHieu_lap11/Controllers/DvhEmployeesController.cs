using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DinhVanHieu_lap11.Models;

namespace DinhVanHieu_lap11.Controllers
{
    public class DvhEmployeesController : Controller
    {
        private readonly DinhVanHieuLap11Context _context;

        public DvhEmployeesController(DinhVanHieuLap11Context context)
        {
            _context = context;
        }

        // GET: DvhEmployees
        public async Task<IActionResult> DvhIndex()
        {
            return View(await _context.DvhEmployees.ToListAsync());
        }

        // GET: DvhEmployees/Details/5
        public async Task<IActionResult> DvhDetails(int? Dvhid)
        {
            if (Dvhid == null)
            {
                return NotFound();
            }

            var dvhEmployee = await _context.DvhEmployees
                .FirstOrDefaultAsync(m => m.DvhEmpId == Dvhid);
            if (dvhEmployee == null)
            {
                return NotFound();
            }

            return View(dvhEmployee);
        }

        // GET: DvhEmployees/DvhCreate
        public IActionResult DvhCreate()
        {
            return View();
        }

        // POST: DvhEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DvhCreate([Bind("DvhEmpId,DvhEmpName,DvhEmpLevel,DvhEmpStartDate,DvhEmpStatus")] DvhEmployee dvhEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dvhEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DvhIndex));
            }
            return View(dvhEmployee);
        }

        // GET: DvhEmployees/Edit/5
        public async Task<IActionResult> DvhEdit(int? Dvhid)
        {
            if (Dvhid == null)
            {
                return NotFound();
            }

            var dvhEmployee = await _context.DvhEmployees.FindAsync(Dvhid);
            if (dvhEmployee == null)
            {
                return NotFound();
            }
            return View(dvhEmployee);
        }

        // POST: DvhEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DvhEdit(int Dvhid, [Bind("DvhEmpId,DvhEmpName,DvhEmpLevel,DvhEmpStartDate,DvhEmpStatus")] DvhEmployee dvhEmployee)
        {
            if (Dvhid != dvhEmployee.DvhEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dvhEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DvhEmployeeExists(dvhEmployee.DvhEmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(DvhIndex));
            }
            return View(dvhEmployee);
        }

        // GET: DvhEmployees/Delete/5
        public async Task<IActionResult> DvhDelete(int? Dvhid)
        {
            if (Dvhid == null)
            {
                return NotFound();
            }

            var dvhEmployee = await _context.DvhEmployees
                .FirstOrDefaultAsync(m => m.DvhEmpId == Dvhid);
            if (dvhEmployee == null)
            {
                return NotFound();
            }

            return View(dvhEmployee);
        }

        // POST: DvhEmployees/Delete/5
        [HttpPost, ActionName("DvhDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Dvhid)
        {
            var dvhEmployee = await _context.DvhEmployees.FindAsync(Dvhid);
            if (dvhEmployee != null)
            {
                _context.DvhEmployees.Remove(dvhEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DvhIndex));
        }

        private bool DvhEmployeeExists(int Dvhid)
        {
            return _context.DvhEmployees.Any(e => e.DvhEmpId == Dvhid);
        }
    }
}
