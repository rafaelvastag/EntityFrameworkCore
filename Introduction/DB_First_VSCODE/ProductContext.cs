using DB_First_VSCODE.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB_First_VSCODE
{
    public class ProductContext : DbContext
    {

        public DbSet<Product> Products {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NKE9617\\SQLEXPRESS;Initial Catalog=EntityFrameworkDB;User Id=vastag;Password=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}