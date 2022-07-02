using Mozika.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mozika.EFCore.Configurations
{
    public class ArtistConfiguration
    {
        public ArtistConfiguration(EntityTypeBuilder<Artist> entity)
        {
            entity.HasIndex(e => e.ArtistId)
                .HasName("IPK_Artist");

            entity.Property(e => e.Name).HasMaxLength(120);
        }
    }
}