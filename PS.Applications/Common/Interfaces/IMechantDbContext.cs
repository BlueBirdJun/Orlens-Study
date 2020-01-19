using Microsoft.EntityFrameworkCore;
using PS.Database.Models.db_Mechant;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PS.Applications.Common.Interfaces
{
    public interface IMechantDbContext
    {
        DbSet<Tblbrand> brand { get; set; }
        DbSet<TblbrandHis> tbltest { get; set; }

        //DbSet<Brandhis> brandhis { get; set; }

        //DbSet<Category> Orders { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
