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
    public class ArtistModel : PageModel
    {
        private readonly ILogger<ArtistModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
        public IList<ArtistApiModel> artists;
        public IList<ArtistApiModel> all;

        public ArtistModel(ILogger<ArtistModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
        }

        public void OnGet(int paginationId = 0)
        {
            all = _MozikaSupervisor.GetAllArtistWithAlbumsCount().ToList();
            artists = all.ToListPaginate(paginationId, 32);
        }
    }
}
