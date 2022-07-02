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
    public class EmployeeModel : PageModel
    {
        private readonly ILogger<EmployeeModel> _logger;
        private readonly IMozikaSupervisor _MozikaSupervisor;
        public IList<EmployeeApiModel> employees;
        public IList<EmployeeApiModel> all;

        public EmployeeModel(ILogger<EmployeeModel> logger, IMozikaSupervisor MozikaSupervisor)
        {
            _logger = logger;
            _MozikaSupervisor = MozikaSupervisor;
        }

        public void OnGet(int paginationId)
        {
            all = _MozikaSupervisor.GetAllEmployee().ToList();
            employees = all.ToListPaginate(paginationId, 30);
        }
    }
}
