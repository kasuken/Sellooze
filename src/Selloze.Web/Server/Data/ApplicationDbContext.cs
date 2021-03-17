using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Selloze.Web.Server.Models;
using Selloze.Web.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selloze.Web.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(IHttpContextAccessor httpContextAccessor,
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetCurrentUser()
        {
            return _httpContextAccessor.HttpContext.User.Identity.Name;
        }

        public DbSet<Agent> Agents { get; set; }
    }
}
