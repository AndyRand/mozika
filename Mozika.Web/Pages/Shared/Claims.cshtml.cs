using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Mozika.Web.Pages
{
    public class ClaimsModel : PageModel
    {
        private readonly ILogger<ClaimsModel> _logger;
       

        public ClaimsModel(ILogger<ClaimsModel> logger)
        {
            _logger = logger;
           
        }

        public void OnGet()
        {
            
           
        }
    }
}
