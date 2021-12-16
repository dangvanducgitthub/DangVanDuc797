using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DangVanDuc797Models;
namespace DangVanDuc797.Data{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DangVanDuc797Models.CompanyDVD797> CompanyDVD797 { get; set; }
    }
}
    
