using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMenu.Domain.Entities.Base;

namespace TheMenu.Domain.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
