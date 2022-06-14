using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EF_Core_Code_First
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // define a COnection String Here
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SimHealth;Integrated Security=SSPI");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
