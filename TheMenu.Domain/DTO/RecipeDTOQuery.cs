using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMenu.Domain.Entities;

namespace TheMenu.Domain.DTO
{
    public class RecipeDTOQuery
    {
        public RecipeDTOQuery(Recipe recipe)
        {
            Name = recipe.Name;
            PossibleOrigen = recipe.PossibleOrigen;
            Comment = recipe.Comment;
            Preparation = recipe.Preparation;
        }
        public string Name { get; set; }
        public string PossibleOrigen { get; set; }
        public string Comment { get; set; }
        public string Preparation { get; set; }
    }
}
