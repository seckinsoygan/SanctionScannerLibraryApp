using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Shared
{
    public class AppDbContext : DbContext
    {
        //EF kullanılarak yapılan veritabanı bağlantısı ve class ile db table bağlantısı.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SsLibraryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Book> Books { get; set; }
    }
}
