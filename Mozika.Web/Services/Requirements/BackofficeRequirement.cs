using System;
using Microsoft.AspNetCore.Authorization;
namespace Mozika.Web.Services.Requirements
{
    public class BackofficeRequirement: IAuthorizationRequirement
    {
        public string authorizedId = "";
        public BackofficeRequirement(string authorizedId)
        {
            this.authorizedId = authorizedId;
        }
    }
}
