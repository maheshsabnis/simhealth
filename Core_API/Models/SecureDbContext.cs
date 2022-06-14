using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Core_API.Models
{
    /// <summary>
    /// Db COntext class that will be used for createing Tables
    /// for storing security information 
    /// </summary>
    public class SecureDbContext : IdentityDbContext<IdentityUser>
    {
        /// <summary>
        /// This constructor will be invoked by ASP.NET Core IServiceCollection
        /// and will register the SecurityContext in DI COntainer 
        /// services.AddDbContext<SecureDbContext>
        /// </summary>
        /// <param name="options"></param>
        public SecureDbContext(DbContextOptions<SecureDbContext> options):base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
