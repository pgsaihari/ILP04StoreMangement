using ILP04_StoreMangement.Model;
using Microsoft.AspNetCore.Mvc;

namespace ILP04_StoreMangement.Interface
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<bool> AddCategory( Category category);
        Task<bool> DeleteCategory(int id);

        


    }
}
