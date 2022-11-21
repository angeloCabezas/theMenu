using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Data;

namespace TheMenu.Infrastructure.Repositories
{
    public class UnitOfWork
    {
        private readonly IIngredientRepository? _ingredientRepository;
        private readonly IRecipeRepository? _recipeRepository;
        private readonly TheMenuDBContext _dbContext;
        public UnitOfWork(TheMenuDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRecipeRepository recipeRepository => (_recipeRepository == null ? new RecipeRepository(_dbContext) : _recipeRepository);
        public IIngredientRepository ingredientRepository => (_ingredientRepository == null ? new IngredientRepository(_dbContext) : _ingredientRepository);

        public int SaveChanges() {
            return _dbContext.SaveChanges();
        }
    
    }
}
