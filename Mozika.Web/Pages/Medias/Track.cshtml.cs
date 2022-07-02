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
    [BindProperties]
    public class TrackModel : PageModel
    {
        private readonly ILogger<TrackModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
       

        [BindProperty]
        public IList<TrackApiModel> tracks { get; set; }
        public IList<TrackApiModel> all;

        public TrackModel(ILogger<TrackModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
        }

        public async Task<IActionResult> OnGetAsync(int paginationId = 0)
        {
            all = await _MozikaSupervisor.GetAllTrackAsync().ContinueWith(it => it.Result.ToList());
            tracks = all.ToListPaginate(paginationId, 30);
            return Page();
        }

        public static double GetPercentage(double size)
        {
            return Math.Min((size/ 393599), 98); 
        }
    }
}
