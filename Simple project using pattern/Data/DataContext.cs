using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Simple_project_using_pattern.Data
{
    public class DataContext : DbContext
    {
       
        public DataContext(DbContextOptions<DataContext>options) : base(options)   
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-HJM6ACK\\SQLEXPRESS;Database=Usertestdb;Trusted_Connection=true;TrustedServerCertificate=true;");
            
        }
        public DbSet<UserTestDTO> UserTestDTOs { get; set; }
    }
}
