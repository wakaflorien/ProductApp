using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Productsell.Data;
using Productsell.Models;

namespace Productsell.Pages_ProductPages
{
    public class EditModel : PageModel
    {
        private readonly Productsell.Data.ProductContext _context;

        public EditModel(Productsell.Data.ProductContext context)
        {
            _context = context;
        }

        [BindProperty]
        public products products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            products = await _context.Productses.FirstOrDefaultAsync(m => m.Id == id);

            if (products == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(products).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!productsExists(products.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool productsExists(int id)
        {
            return _context.Productses.Any(e => e.Id == id);
        }
    }
}
