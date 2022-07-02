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
    public class PlaylistDetailsModel : PageModel
    {
        private readonly ILogger<PlaylistDetailsModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
        public IList<TrackApiModel> tracks;
        public IList<TrackApiModel> all;
        public string playlistId = "";

        public PlaylistDetailsModel(ILogger<PlaylistDetailsModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
        }

        public void OnGet(string playlistId, int paginationId = 0)
        {
            this.playlistId = playlistId;
            all = _MozikaSupervisor.GetTrackByPlaylistId(int.Parse(playlistId)).ToList();
            tracks = all.ToListPaginate(paginationId, 32);
        }
    }
}
