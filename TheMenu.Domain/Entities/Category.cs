using TheMenu.Domain.Entities.Base;

namespace TheMenu.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string name { get; set; }
        public string description { get; set; }
        public IEnumerable<CategoryRecipe> CategoryRecipes { get; set; }
    }
}