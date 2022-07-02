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
using Microsoft.AspNetCore.Authorization;

namespace Mozika.Web.Pages
{
    [Authorize(Policy = "Backoffice")]
    public class CustomerModel : PageModel
    {
        private readonly ILogger<CustomerModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
        public IList<CustomerApiModel> customers;
        public IList<CustomerApiModel> all; 

        public CustomerModel(ILogger<CustomerModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
        }

        public void OnGet(int paginationId = 0)
        {
            all = _MozikaSupervisor.GetAllCustomer().ToList();
            customers = all.ToListPaginate(paginationId, 30);
        }
    }
}
