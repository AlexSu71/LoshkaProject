using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LoshkaLibrary.Models;

namespace LoshkaLibrary.Data.Configurations
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasKey(u => u.UnitID);
            builder.Property(u => u.UnitName).IsRequired().HasMaxLength(100);
            builder.HasIndex(u => u.UnitName).IsUnique();
        }
    }
}
