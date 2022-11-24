using TheMenu.Domain.Entities;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Data;

namespace TheMenu.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TheMenuDBContext _dbContext;

        public CategoryRepository(TheMenuDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Category>> GetRecipesByCategory(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}