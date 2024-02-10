namespace LoshkaDAL.Models

{
    public class Ingredient
    {
        public Ingredient() => RecipeIngredients = new HashSet<RecipeIngredient>();

        public int IngredientId { get; set; }
        public string? IngredientName { get; set; }

        public int? NutritionalValueId { get; set; }

        public virtual NutritionalValue NutritionalValue { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
