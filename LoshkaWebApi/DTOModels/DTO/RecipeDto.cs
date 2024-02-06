namespace LoshkaWebApi.DTOModels.DTO
{
    public class RecipeDto
    {
        public int RecipeId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? PreparationTime { get; set; }
        public int? CookingTime { get; set; }
        public string? VideoURL { get; set; }
        public string? PhotoURL { get; set; }
        public string? TextRecipesURL { get; set; }
    }
}
