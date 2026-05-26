using Microsoft.EntityFrameworkCore;
using QuanLyHangHoaAPI.Models;

namespace QuanLyHangHoaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<HangHoa> HangHoas { get; set; }

        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
    }
}