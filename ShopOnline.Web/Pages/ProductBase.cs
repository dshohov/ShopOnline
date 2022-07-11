using Microsoft.AspNetCore.Components;
using ShopOnline.Model.Dots;
using ShopOnline.Web.Service.Contracts;

namespace ShopOnline.Web.Pages
{
    public class ProductBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
    }
}
