using ILP04_StoreMangement.Data;
using ILP04_StoreMangement.Interface;
using ILP04_StoreMangement.Model;
using Microsoft.AspNetCore.Mvc;

namespace ILP04_StoreMangement.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private ApiDbContext _dbContext;
        public CategoryRepository(ApiDbContext dbContext)
        {
          _dbContext = dbContext;
        }

        public async Task<bool> AddCategory( Category category)
        {
            var guid = Guid.NewGuid();
            var filePath = Path.Combine("wwwroot", guid+ ".jpeg" );
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
               await category.Image.CopyToAsync(fileStream);
            }
            category.ImageUrl = filePath.Substring("wwwroot".Length + 1);

            var isAdded= await _dbContext.Categories.AddAsync(category);
            if (isAdded != null) {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
               return false;
            }
            
        }

        public Task<bool> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
