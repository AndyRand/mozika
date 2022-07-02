using System.Collections.Generic;
using Mozika.Domain.Converters;
using Mozika.Domain.Entities;

namespace Mozika.Domain.ApiModels
{
    public class GenreApiModel : IConvertModel<GenreApiModel, Genre>
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public IList<TrackApiModel> Tracks { get; set; }
        
        public Genre Convert() =>
            new Genre
            {
                GenreId = GenreId,
                Name = Name
            };
    }
}