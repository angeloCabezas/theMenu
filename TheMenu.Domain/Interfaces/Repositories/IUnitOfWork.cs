namespace TheMenu.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IIngredientRepository IngredientRepository { get; }
        IRecipeRepository RecipeRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        int SaveChanges();
    }
}