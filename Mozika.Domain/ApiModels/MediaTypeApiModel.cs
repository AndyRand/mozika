using System.Collections.Generic;
using Mozika.Domain.Converters;
using Mozika.Domain.Entities;

namespace Mozika.Domain.ApiModels
{
    public class MediaTypeApiModel : IConvertModel<MediaTypeApiModel, MediaType>
    {
        public int MediaTypeId { get; set; }
        public string Name { get; set; }
        public IList<TrackApiModel> Tracks { get; set; }

        public MediaType Convert() =>
            new MediaType
            {
                MediaTypeId = MediaTypeId,
                Name = Name
            };
    }
}