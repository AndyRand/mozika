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
    public class AlbumModel : PageModel
    {
        private readonly ILogger<AlbumModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
        public IList<AlbumApiModel> albums;
        public IList<AlbumApiModel> all;

        public AlbumModel(ILogger<AlbumModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
        }

        public void OnGet(int paginationId = 0)
        {
            all = _MozikaSupervisor.GetAllAlbum().ToList();
            albums = all.ToListPaginate(paginationId, 30);
        }
    }
}
