using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Productsell.Data;
using Productsell.Models;

namespace Productsell.Pages_ProductPages
{
    public class CreateModel : PageModel
    {
        private readonly Productsell.Data.ProductContext _context;

        public CreateModel(Productsell.Data.ProductContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public products products { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Productses.Add(products);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
