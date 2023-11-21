using EcommercePatrick.Shared.Models;

namespace EcommercePatrick.Client.Services.ProductServices
{
    public interface IProductServices
    {
        List<Product> Products { get; }
        void LoadProducts();
    }
}
