using LoshkaLibrary.Interfaces;
using LoshkaLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace LoshkaLibrary.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options), IAppDbContext
    {
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredient { get; set; }
        public DbSet<Category> Categorie { get; set; }
        public DbSet<RecipeCategory> RecipeCategorie { get; set; }
        public DbSet<NutritionalValue> NutritionalValue { get; set; }
        public DbSet<YouTubeVideos> YouTubeVideos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }   
    }
}
