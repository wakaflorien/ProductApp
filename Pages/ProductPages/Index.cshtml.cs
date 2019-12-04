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
    public class IndexModel : PageModel
    {
        private readonly Productsell.Data.ProductContext _context;

        public IndexModel(Productsell.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<products> products { get;set; }

        public async Task OnGetAsync()
        {
            products = await _context.Productses.ToListAsync();
        }
    }
}
