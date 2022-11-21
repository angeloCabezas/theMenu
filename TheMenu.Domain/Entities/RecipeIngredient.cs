using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMenu.Domain.Entities.Base;

namespace TheMenu.Domain.Entities
{
    public class RecipeIngredient : BaseEntity
    {
        public Ingredient Ingredient { get; set; }
        public Recipe Recipe { get; set; }
        public int Amount { get; set; }
        public int Measure { get; set; }
        public int Comment { get; set; }
    }
}
