using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Mozika.Domain.ApiModels;
using Mozika.Domain.Extensions;
using Mozika.Domain.Supervisor;

namespace Mozika.Web.Pages
{
    public class ArtistDetailsModel : PageModel
    {
        private readonly ILogger<PlaylistDetailsModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
        public Dictionary<int, IList<TrackApiModel>> alltracks = new Dictionary<int, IList<TrackApiModel>>();
        public IList<AlbumApiModel> albums;
        public ArtistApiModel artist;
        public double totalPrice = 0;

        public ArtistDetailsModel(ILogger<PlaylistDetailsModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
        }

        public void OnGet(string id)
        {
            
            artist  = _MozikaSupervisor.GetArtistById(int.Parse(id));
            albums = _MozikaSupervisor.GetAlbumByArtistId(artist.ArtistId).ToList();
            foreach(var album in albums)
            {
                IList<TrackApiModel> albumTracks;
                albumTracks= _MozikaSupervisor.GetTrackByAlbumId(album.AlbumId).ToList();
                alltracks.Add(album.AlbumId, albumTracks);
                totalPrice += albumTracks.SumTrackPrice();
            }
        }
    }
}
