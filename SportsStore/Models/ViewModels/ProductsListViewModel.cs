using SportsStore.Models.ViewModels;
using SportsStore.Models;

namespace SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        = Enumerable.Empty<Product>();

		public PagingInfo PagingInfo { get; set; } = new();
        
        public string? CurrentCategory { get; set; }

    }
}