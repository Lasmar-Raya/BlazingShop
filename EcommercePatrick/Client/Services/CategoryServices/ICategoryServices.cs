using EcommercePatrick.Shared.Models;

namespace EcommercePatrick.Client.Services.CategoryServices
{
    public interface ICategoryServices
    {
        List<Category> Categories { get; }
        void LoadCategories();
    }
}
