namespace LoshkaLibrary.Models
{
    public class NutritionalValue
    {
        public int NutritionalValueId { get; set; }
        public decimal? Protein { get; set; }
        public decimal? Fat { get; set; }
        public decimal? Carbohydrates { get; set; }
        public decimal? Fiber { get; set; }
        public int? Calories { get; set; }

        public virtual required Ingredient Ingredient { get; set; }
    }
}
