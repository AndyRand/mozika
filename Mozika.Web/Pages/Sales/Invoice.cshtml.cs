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
    public class InvoiceModel : PageModel
    {
        private readonly ILogger<InvoiceModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
        public IList<InvoiceApiModel> invoices;
        public IList<InvoiceApiModel> all;



        public InvoiceModel(ILogger<InvoiceModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
            
        }

        public void OnGet(int paginationId=0)
        {
            all = _MozikaSupervisor.GetAllInvoice().ToList();
            invoices = all.ToListPaginate(paginationId, 50);
        }
    }
}
