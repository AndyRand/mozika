using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Mozika.Domain.ApiModels;
using Mozika.Domain.Supervisor;

namespace Mozika.Web.Pages
{
    public class PaginationModel : PageModel
    {
        public PaginationApiModel paginationApiModel;
        public PaginationModel(int totalRecords, string url, int RecordsPerPage = 20)
        {
            paginationApiModel = new PaginationApiModel
            {
                TotalRecords = totalRecords,
                RecordsPerPage = RecordsPerPage,
                UrlParams = url
                
            };

        }

        public void OnGet()
        {


        }
    }
}
