using TheMenu.Domain.Entities.Base;

namespace TheMenu.Domain.Entities
{
    public class CategoryRecipe : BaseEntity
    {
        public Category Category { get; set; }
        public Recipe Recipe { get; set; }
    }
}