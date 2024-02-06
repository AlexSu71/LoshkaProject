namespace LoshkaLibrary.Models
{
    public class RecipeCategory
    {
        public int RecipeCategoryId { get; set; }

        public int RecipeId { get; set; }
        public int CategoryId { get; set; }

        public virtual required Recipe Recipe { get; set; }
        public virtual required Category Category { get; set; }
    }
}
