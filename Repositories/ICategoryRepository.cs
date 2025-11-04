using VShop.ProductApi.Models;

namespace VShop.ProductApi.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<IEnumerable<Category>> GetCategoriesWithProducts();
        Task<Category?> GetById(int id);
        Task<Category> Create(Category category);
        Task<Category?> Update(int id, Category category);
        Task<Category> Delete(int id);
    }
}
