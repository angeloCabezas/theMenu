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
    public class IngredientRepository : IIngredientRepository
    {
        private readonly TheMenuDBContext _dbContext;

        public IngredientRepository(TheMenuDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _dbContext.Ingredients.ToList();
        }
    }
}
