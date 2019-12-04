using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Productsell.Data
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options) {}
        public DbSet<Models.products> Productses  { get; set; }
    }
}