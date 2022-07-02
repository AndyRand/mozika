using Mozika.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mozika.EFCore.Configurations
{
    public class PlaylistConfiguration
    {
        public PlaylistConfiguration(EntityTypeBuilder<Playlist> entity)
        {
            entity.HasIndex(e => e.PlaylistId)
                .HasName("IPK_Playlist");

            entity.Property(e => e.Name).HasMaxLength(120);
        }
    }
}