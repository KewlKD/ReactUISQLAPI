using Microsoft.EntityFrameworkCore;


namespace ReactUISQLServer.Models
{
    public class CompDBContext : DbContext
    {

        public CompDBContext()
        {

        }

        public CompDBContext(DbContextOptions<CompDBContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("connectionstring");
            }
        }
    }
}


