namespace LoshkaDAL.Models
{
    public class Category
    {
        public Category() => RecipeCategories = new HashSet<RecipeCategory>();

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual ICollection<RecipeCategory> RecipeCategories { get; set; }
    }
}
