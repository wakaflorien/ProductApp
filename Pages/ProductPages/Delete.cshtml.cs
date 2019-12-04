using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Productsell.Data;
using Productsell.Models;

namespace Productsell.Pages_ProductPages
{
    public class DeleteModel : PageModel
    {
        private readonly Productsell.Data.ProductContext _context;

        public DeleteModel(Productsell.Data.ProductContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            products = await _context.Productses.FindAsync(id);

            if (products != null)
            {
                _context.Productses.Remove(products);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
