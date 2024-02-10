using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LoshkaDAL.Models;

namespace LoshkaDAL.Data.Configurations
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
