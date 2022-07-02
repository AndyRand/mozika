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
    public class AlbumDetailsModel : PageModel
    {
        private readonly ILogger<PlaylistDetailsModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
        public IList<TrackApiModel> tracks;
        public AlbumApiModel album;
        public ArtistApiModel artist;

        public AlbumDetailsModel(ILogger<PlaylistDetailsModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
        }

        public void OnGet(string id)
        {
            album   = _MozikaSupervisor.GetAlbumById(int.Parse(id));
            artist  = _MozikaSupervisor.GetArtistById(album.ArtistId);
            tracks  = _MozikaSupervisor.GetTrackByAlbumId(int.Parse(id)).ToList();
            album.AlbumPrice = tracks.SumTrackPrice();
        }
    }
}
