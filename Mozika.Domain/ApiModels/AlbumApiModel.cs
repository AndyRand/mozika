using System.Collections.Generic;
using Mozika.Domain.Converters;
using Mozika.Domain.Entities;

namespace Mozika.Domain.ApiModels
{
    public class AlbumApiModel : IConvertModel<AlbumApiModel, Album>
    {
        public int AlbumId { get; set; }
        public string Title { get; set; } 
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public ArtistApiModel Artist { get; set; }
        public IList<TrackApiModel> Tracks { get; set; }

        public double AlbumPrice {get;set;}
        public Album Convert() =>
            new Album
            {
                AlbumId = AlbumId,
                ArtistId = ArtistId,
                Title = Title
            };
    }
}