using Mozika.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mozika.EFCore.Configurations
{
    public class TrackConfiguration
    {
        public TrackConfiguration(EntityTypeBuilder<Track> entity)
        {
            entity.HasIndex(e => e.AlbumId)
                .HasName("IFK_Album_Track");

            entity.HasIndex(e => e.GenreId)
                .HasName("IFK_Genre_Track");

            entity.HasIndex(e => e.MediaTypeId)
                .HasName("IFK_MediaType_Track");

            entity.HasIndex(e => e.TrackId)
                .HasName("IPK_Track");

            entity.Property(e => e.Composer).HasMaxLength(220);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.UnitPrice).HasColumnType("numeric(10, 2)");

            entity.HasOne(d => d.Album)
                .WithMany(p => p.Tracks)
                .HasForeignKey(d => d.AlbumId)
                .HasConstraintName("FK__Track__AlbumId__286302EC");

            entity.HasOne(d => d.Genre)
                .WithMany(p => p.Tracks)
                .HasForeignKey(d => d.GenreId)
                .HasConstraintName("FK__Track__GenreId__2A4B4B5E");

            entity.HasOne(d => d.MediaType)
                .WithMany(p => p.Tracks)
                .HasForeignKey(d => d.MediaTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Track__MediaType__29572725");
        }
    }
}