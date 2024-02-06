namespace LoshkaLibrary.Models
{
    public class RecipeIngredient
    {
        public int RecipeIngredientId { get; set; }

        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int UnitId { get; set; }

        public decimal? Quantity { get; set; }

        public virtual required Recipe Recipe { get; set; }
        public virtual required Ingredient Ingredient { get; set; }
        public virtual required Unit Unit { get; set; }
    }
}
