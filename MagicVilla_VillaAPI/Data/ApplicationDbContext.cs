using Microsoft.EntityFrameworkCore;
using MagicVilla_VillaAPI.Models;


namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        // 添加构造函数以接受 DbContextOptions
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties
        public DbSet<Villa> Villas { get; set; }
    }
}
