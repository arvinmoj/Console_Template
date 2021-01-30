using Models;
using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Password=A!1q2w3e!;Persist Security Info=True;User ID=SA; Initial Catalog = Console_Application; Data Source=ASUS\\SQLSERVER");
        }

        public DbSet<Model> Models { get; set; }

    }
}
