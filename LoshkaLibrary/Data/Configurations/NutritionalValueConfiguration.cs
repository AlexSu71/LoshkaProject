using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LoshkaLibrary.Models;

namespace LoshkaLibrary.Data.Configurations
{
    public class NutritionalValueConfiguration : IEntityTypeConfiguration<NutritionalValue>
    {
        public void Configure(EntityTypeBuilder<NutritionalValue> builder)
        {
            builder.HasKey(nv => nv.NutritionalValueId);

            builder.Property(nv => nv.Protein).IsRequired(true);
            builder.Property(nv => nv.Fat).IsRequired(true);
            builder.Property(nv => nv.Carbohydrates).IsRequired(true);
            builder.Property(nv => nv.Fiber).IsRequired(true);
            builder.Property(nv => nv.Calories).IsRequired(true);

            builder.HasOne(nv => nv.Ingredient)
                   .WithOne(i => i.NutritionalValue)
                   .HasForeignKey<NutritionalValue>(nv => nv.NutritionalValueId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
