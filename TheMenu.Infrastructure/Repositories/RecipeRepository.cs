using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMenu.Domain.Entities;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Data;

namespace TheMenu.Infrastructure.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly TheMenuDBContext _context;
        public RecipeRepository(TheMenuDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Recipe>> GetAllRecipes()
        {
            return await _context.Recipes.ToListAsync();
        }
        public async Task<IEnumerable<Recipe>> GetAllRecipesByCategory(Guid CategoryId)
        {
            return await _context.Recipes.ToListAsync();
        }

        public async Task<Recipe> GetRecipe(Guid Id)
        {
            return await _context.Recipes.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
    }
}
