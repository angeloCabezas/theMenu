namespace TheMenu.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IIngredientRepository ingredientRepository { get; }
        IRecipeRepository recipeRepository { get; }
        int SaveChanges();
    }
}