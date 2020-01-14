using Microsoft.EntityFrameworkCore;
using PS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PS.Applications.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<tblbrand> brand { get; set; }
        DbSet<tbltest> tbltest { get; set; }

        //DbSet<Brandhis> brandhis { get; set; }

        //DbSet<Category> Orders { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
