using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalMVC.Models;

namespace ProjetoFinalMVC.Data
{
    public class ProjetoFinalMVCContext : DbContext
    {
        public ProjetoFinalMVCContext (DbContextOptions<ProjetoFinalMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
