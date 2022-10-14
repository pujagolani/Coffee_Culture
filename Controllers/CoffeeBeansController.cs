using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Coffee_Culture.Data;
using Coffee_Culture.Models;

namespace Coffee_Culture.Controllers
{
    public class CoffeeBeansController : Controller
    {
        private readonly Coffee_CultureContext _context;

        public CoffeeBeansController(Coffee_CultureContext context)
        {
            _context = context;
        }

        // GET: Coffees
        public async Task<IActionResult> Index(string CoffeeRoasting, string searchString)
        {
            // Use LINQ to get list of Roasting.
            IQueryable<string> roastingQuery = from m in _context.CoffeeBean
                                            orderby m.Roasting
                                            select m.Roasting;

            var coffeeBeans = from m in _context.CoffeeBean
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                coffeeBeans = coffeeBeans.Where(s => s.Types_Of_Coffee.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(CoffeeRoasting))
            {
                coffeeBeans = coffeeBeans.Where(x => x.Roasting == CoffeeRoasting);
            }

            var CoffeeRoastingVM = new CoffeeRoastingViewModel
            {
                Roastings = new SelectList(await roastingQuery.Distinct().ToListAsync()),
                CoffeeBeans = await coffeeBeans.ToListAsync()
            };

            return View(CoffeeRoastingVM);
        }

        // GET: CoffeeBeans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coffeeBean = await _context.CoffeeBean
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coffeeBean == null)
            {
                return NotFound();
            }

            return View(coffeeBean);
        }

        // GET: CoffeeBeans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CoffeeBeans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Types_Of_Coffee,Manufacture_Date,Production_Country,Roasting,Price,Description_Of_Product,Packaging")] CoffeeBean coffeeBean)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coffeeBean);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coffeeBean);
        }

        // GET: CoffeeBeans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coffeeBean = await _context.CoffeeBean.FindAsync(id);
            if (coffeeBean == null)
            {
                return NotFound();
            }
            return View(coffeeBean);
        }

        // POST: CoffeeBeans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Types_Of_Coffee,Manufacture_Date,Production_Country,Roasting,Price,Description_Of_Product,Packaging")] CoffeeBean coffeeBean)
        {
            if (id != coffeeBean.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coffeeBean);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoffeeBeanExists(coffeeBean.Id))
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
            return View(coffeeBean);
        }

        // GET: CoffeeBeans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coffeeBean = await _context.CoffeeBean
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coffeeBean == null)
            {
                return NotFound();
            }

            return View(coffeeBean);
        }

        // POST: CoffeeBeans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coffeeBean = await _context.CoffeeBean.FindAsync(id);
            _context.CoffeeBean.Remove(coffeeBean);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoffeeBeanExists(int id)
        {
            return _context.CoffeeBean.Any(e => e.Id == id);
        }
    }
}
