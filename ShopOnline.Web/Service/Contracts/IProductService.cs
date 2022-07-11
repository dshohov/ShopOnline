using ShopOnline.Model.Dots;

namespace ShopOnline.Web.Service.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();

    }
}
