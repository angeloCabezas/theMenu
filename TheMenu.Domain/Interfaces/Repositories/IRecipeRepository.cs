﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMenu.Domain.Entities;

namespace TheMenu.Domain.Interfaces.Repositories
{
    public interface IRecipeRepository
    {
        Recipe GetRecipe(Guid Id);
        IEnumerable<Recipe> GetAllRecipes();
    }
}
