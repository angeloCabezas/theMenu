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
        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _context.Recipes.ToList();
        }
        
        public Recipe GetRecipe(Guid Id)
        {
            return _context.Recipes.Where(x => x.Id == Id).FirstOrDefault();
        }
    }
}
