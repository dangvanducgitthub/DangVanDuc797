using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DangVanDuc797Models;
using DangVanDuc797.Data;
namespace DangVanDuc797.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Company
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyDVD797.ToListAsync());
        }

        // GET: Company/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyDVD797 = await _context.CompanyDVD797
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyDVD797 == null)
            {
                return NotFound();
            }

            return View(companyDVD797);
        }

        // GET: Company/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyDVD797 companyDVD797)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyDVD797);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyDVD797);
        }

        // GET: Company/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyDVD797 = await _context.CompanyDVD797.FindAsync(id);
            if (companyDVD797 == null)
            {
                return NotFound();
            }
            return View(companyDVD797);
        }

        // POST: Company/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyId,CompanyName")] CompanyDVD797 companyDVD797)
        {
            if (id != companyDVD797.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyDVD797);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyDVD797Exists(companyDVD797.CompanyId))
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
            return View(companyDVD797);
        }

        // GET: Company/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyDVD797 = await _context.CompanyDVD797
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyDVD797 == null)
            {
                return NotFound();
            }

            return View(companyDVD797);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companyDVD797 = await _context.CompanyDVD797.FindAsync(id);
            _context.CompanyDVD797.Remove(companyDVD797);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyDVD797Exists(int id)
        {
            return _context.CompanyDVD797.Any(e => e.CompanyId == id);
        }
    }
}
