using LoshkaDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LoshkaDAL.Interfaces
{
    public interface IAppDbContext : IDisposable
    {
        DbSet<Unit> Unit { get; }
        DbSet<Ingredient> Ingredient { get; }
        DbSet<Recipe> Recipe { get; }
        DbSet<RecipeIngredient> RecipeIngredient { get; }
        DbSet<Category> Categorie { get; }
        DbSet<RecipeCategory> RecipeCategorie { get; }
        DbSet<NutritionalValue> NutritionalValue { get; }
        DbSet<YouTubeVideos> YouTubeVideos { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
