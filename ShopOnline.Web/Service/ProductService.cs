using ShopOnline.Model.Dots;
using ShopOnline.Web.Service.Contracts;
using System.Net.Http.Json;

namespace ShopOnline.Web.Service
{
    public class ProductService : IProductService
    { 
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;
            }
            catch (Exception)
            {
                //Log exeption
                throw;
            }
        }
    }
}
