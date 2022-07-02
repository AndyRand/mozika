using System.Collections.Generic;
using Mozika.Domain.Converters;
using Mozika.Domain.Entities;

namespace Mozika.Domain.ApiModels
{
    public class ArtistApiModel : IConvertModel<ArtistApiModel, Artist>
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public int AlbumsCount { get; set; }
        public IList<AlbumApiModel> Albums { get; set; } = new List<AlbumApiModel>();
        private static string TRIM_SPACE = "                    ";

        public Artist Convert() =>
            new Artist
            {
                ArtistId = ArtistId,
                Name = Name,
                Albums = (ICollection<Album>)Albums,
                AlbumsCount = AlbumsCount
            };
        public string GetArtistVisibleName() => string.Concat(Name, TRIM_SPACE).Substring(0, 15);
        public string GetArtistPseudo() => $"@{string.Concat(Name.Replace(' ','.'), TRIM_SPACE).ToLower().Substring(0, 10)}";
    }
}