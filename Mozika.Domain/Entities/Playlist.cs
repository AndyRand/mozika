using Mozika.Domain.Converters;
using Mozika.Domain.ApiModels;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mozika.Domain.Entities
{
    public class Playlist : IConvertModel<Playlist, PlaylistApiModel>
    {
        public Playlist()
        {
            PlaylistTracks = new HashSet<PlaylistTrack>();
        }

        public int PlaylistId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }
        
        public PlaylistApiModel Convert() =>
            new PlaylistApiModel
            {
                PlaylistId = PlaylistId,
                Name = Name
            };
    }
}