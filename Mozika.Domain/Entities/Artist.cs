using Mozika.Domain.Converters;
using Mozika.Domain.ApiModels;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mozika.Domain.Entities
{
    public class Artist : IConvertModel<Artist, ArtistApiModel>
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
        }

        public int ArtistId { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public int AlbumsCount { get; set; }
        [JsonIgnore]
        public virtual ICollection<Album> Albums { get; set; }
        
        public ArtistApiModel Convert() =>
            new ArtistApiModel
            {
                ArtistId = ArtistId,
                Name = Name,
                AlbumsCount = AlbumsCount
            };
    }
}