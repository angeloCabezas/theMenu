using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMenu.Domain.Entities.Base;

namespace TheMenu.Domain.Entities
{
    public class Recipe : BaseEntity
    {
        public string Name { get; set; }
        public string PossibleOrigen { get; set; }
        public string Comment { get; set; }
        public string Preparation { get; set; }
        public IEnumerable<CategoryRecipe> CategoryRecipes { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
