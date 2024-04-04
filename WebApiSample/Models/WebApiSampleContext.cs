using Microsoft.EntityFrameworkCore;

namespace WebApiSample.Models
{
    public class WebApiSampleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C6KH20F\\SQLEXPRESS;Database=WebApiSample;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet <AdminUser> AdminUser { get; set; }


    }
}
