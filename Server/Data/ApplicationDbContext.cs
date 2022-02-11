using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteEventRegistration.Server.Models;
using WebsiteEventRegistration.Shared.Domain;

namespace WebsiteEventRegistration.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Event> Events { get; set; }

        public DbSet<WebsiteEventRegistration.Shared.Domain.Host> Host { get; set; }

        public DbSet<WebsiteEventRegistration.Shared.Domain.User> User { get; set; }

        public DbSet<WebsiteEventRegistration.Shared.Domain.Register> Register { get; set; }
    }
        
}
    


