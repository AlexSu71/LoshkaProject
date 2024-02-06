namespace LoshkaWebApi.DTOModels.DTO
{
    public class RecipeIngredientDto
    {
        public int RecipeIngredientId { get; set; }

        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int UnitId { get; set; }

        public decimal? Quantity { get; set; }
    }
}
