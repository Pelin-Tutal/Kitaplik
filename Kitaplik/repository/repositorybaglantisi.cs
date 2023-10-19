using Kitaplik.Models;
using Microsoft.EntityFrameworkCore;

namespace Kitaplik.repository
{
    public class repositorybaglantisi : DbContext
        
    {
        public repositorybaglantisi(DbContextOptions options) : base(options)
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=Kitaplik_db;Trusted_Connection=true");
        }

        public DbSet<book> Books { get; set; }

    }
}
