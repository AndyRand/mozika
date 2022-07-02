using Mozika.Domain.Converters;
using Mozika.Domain.Entities;

namespace Mozika.Domain.ApiModels
{
    public class PlaylistTrackApiModel : IConvertModel<PlaylistTrackApiModel, PlaylistTrack>
    {
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }
        public PlaylistApiModel Playlist { get; set; }
        public TrackApiModel Track { get; set; }

        public PlaylistTrack Convert() =>
            new PlaylistTrack
            {
                PlaylistId = PlaylistId,
                TrackId = TrackId
            };
    }
}