using Microsoft.EntityFrameworkCore;
using TaizlostSmart.Models;

namespace TaizlostSmart.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // الجداول التي سيتم إنشاؤها في قاعدة البيانات
        public DbSet<Users> Users { get; set; }
        public DbSet<Reports> Reports { get; set; }
    }
}
