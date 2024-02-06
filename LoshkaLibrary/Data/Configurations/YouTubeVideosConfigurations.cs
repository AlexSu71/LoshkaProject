using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LoshkaLibrary.Models;

namespace LoshkaLibrary.Data.Configurations
{
    public class YouTubeVideosConfigurations : IEntityTypeConfiguration<YouTubeVideos>
    {
        public void Configure(EntityTypeBuilder<YouTubeVideos> builder)
        {
            builder.HasKey(y => y.VideoId);
            builder.Property(y => y.VideoURL).IsRequired().HasMaxLength(500);
            builder.Property(y => y.Title).IsRequired().HasMaxLength(255);
            builder.Property(y => y.Description).IsRequired().HasMaxLength(4000);
            builder.Property(y => y.PostedDate).IsRequired().HasMaxLength(100);
        }   
    }
}
