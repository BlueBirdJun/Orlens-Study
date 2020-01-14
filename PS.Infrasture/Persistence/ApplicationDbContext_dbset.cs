using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using PS.Applications.Common.Interfaces;
using PS.Domain.Common;
using PS.Domain.Entities;
using PS.Infrasture.Identity;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using Microsoft.Extensions.Options;

namespace PS.Infrasture.Persistence
{
    public partial class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext
    {
        public DbSet<tblbrand> brand { get; set; }
        public DbSet<tbltest> tbltest { get; set; }
        

        //public DbSet<Brandhis> brandhis { get; set; }
        //public DbSet<Category> Orders { get; set; }
    }
}
