using Mozika.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mozika.EFCore.Configurations
{
    public class GenreConfiguration
    {
        public GenreConfiguration(EntityTypeBuilder<Genre> entity)
        {
            entity.HasIndex(e => e.GenreId)
                .HasName("IPK_Genre");

            entity.Property(e => e.Name).HasMaxLength(120);
        }
    }
}