namespace LoshkaWebApi.DTOModels.DTO
{
    public class NutritionalValueDto
    {
        public int NutritionalValueId { get; set; }
        public decimal? Protein { get; set; }
        public decimal? Fat { get; set; }
        public decimal? Carbohydrates { get; set; }
        public decimal? Fiber { get; set; }
        public int? Calories { get; set; }
    }
}
