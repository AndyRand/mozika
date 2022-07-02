using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Mozika.Web.Services.Requirements;

namespace Mozika.Web.Services.Handlers
{
    public class BackofficeHandler: AuthorizationHandler<BackofficeRequirement>
    {
        public BackofficeHandler()
        {
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, BackofficeRequirement requirement)
        {
            foreach(var claim in context.User.Claims)
            {
                if (claim.Value.Contains(requirement.authorizedId))
                    context.Succeed(requirement);
            }
            
            return Task.CompletedTask;
        }
    }
}
