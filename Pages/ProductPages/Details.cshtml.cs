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
    public class DetailsModel : PageModel
    {
        private readonly Productsell.Data.ProductContext _context;

        public DetailsModel(Productsell.Data.ProductContext context)
        {
            _context = context;
        }

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
    }
}
