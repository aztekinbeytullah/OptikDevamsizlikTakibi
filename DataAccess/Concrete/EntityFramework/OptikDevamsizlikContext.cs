
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class OptikDevamsizlikContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-F009EHO;Initial Catalog=OptikDevamsizlik;Integrated Security=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite");
            
        }

        public DbSet<Kurum> Kurums { get; set; }

    }
}
