using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LoshkaDAL.Models;

namespace LoshkaDAL.Data.Configurations
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasKey(i => i.IngredientId);

            builder.Property(i => i.IngredientName)
                   .IsRequired() 
                   .HasMaxLength(100);

            builder.Property(i => i.NutritionalValueId);

            builder.HasOne(i => i.NutritionalValue)
                   .WithOne()
                   .HasForeignKey<Ingredient>(i => i.NutritionalValueId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(i => i.RecipeIngredients)
                   .WithOne(ri => ri.Ingredient)
                   .HasForeignKey(ri => ri.IngredientId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

