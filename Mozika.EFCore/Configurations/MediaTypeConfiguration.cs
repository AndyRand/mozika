using Mozika.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mozika.EFCore.Configurations
{
    public class MediaTypeConfiguration
    {
        public MediaTypeConfiguration(EntityTypeBuilder<MediaType> entity)
        {
            entity.HasIndex(e => e.MediaTypeId)
                .HasName("IPK_MediaType");

            entity.Property(e => e.Name).HasMaxLength(120);
        }
    }
}