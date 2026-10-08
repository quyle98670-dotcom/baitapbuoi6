using Microsoft.EntityFrameworkCore;

namespace WinFormsApp5
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-M6R9T9B\\SQLEXPRESS;" +
                "Database=QuanLySinhVien;" +
                "Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
