using Microsoft.AspNetCore.Routing.Matching;

namespace Productsell.Models
{
    public class products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}