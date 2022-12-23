using Microsoft.EntityFrameworkCore;


namespace ReactUISQLServer.Models
{
    public partial class CompDBContext : DbContext
    {
        public CompDBContext()
        {
        }

        public CompDBContext(DbContextOptions<CompDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=;Database=;Trusted_Connection=True;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Employeeid);

                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.EmployeeAdd)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
} 


