using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LoshkaLibrary.Models;

namespace LoshkaLibrary.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryName).IsRequired(false).HasMaxLength(100);

            builder.HasMany(c => c.RecipeCategories)
                   .WithOne(rc => rc.Category)
                   .HasForeignKey(rc => rc.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
