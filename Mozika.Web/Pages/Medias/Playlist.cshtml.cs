using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Mozika.Domain.ApiModels;
using Mozika.Domain.Supervisor;
using Mozika.Domain.Extensions;

namespace Mozika.Web.Pages
{
    public class PlaylistModel : PageModel
    {
        private readonly ILogger<PlaylistModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
        public IList<PlaylistApiModel> playlists;
        public IList<PlaylistApiModel> all;

        public PlaylistModel(ILogger<PlaylistModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
        }

        public void OnGet(int paginationId = 0)
        {
            all = _MozikaSupervisor.GetAllPlaylist().ToList();
            playlists = all.ToListPaginate(paginationId, 9);
        }
    }
}
