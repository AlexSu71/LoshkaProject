namespace LoshkaLibrary.Models
{
    public class Recipe
    {
        public Recipe()
        {
            RecipeIngredients = new HashSet<RecipeIngredient>();
            RecipeCategories = new HashSet<RecipeCategory>();
        }

        public int RecipeId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? PreparationTime { get; set; }
        public int? CookingTime { get; set; }
        public string? VideoURL { get; set; }
        public string? PhotoURL { get; set; }
        public string? TextRecipesURL { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public virtual ICollection<RecipeCategory> RecipeCategories { get; set; }

    }
}
