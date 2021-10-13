using Microsoft.EntityFrameworkCore;

#nullable disable

namespace APIServiceTest.Models
{
    public partial class ApiDBContext : DbContext
    {
        public ApiDBContext()
        {
        }

        public ApiDBContext(DbContextOptions<ApiDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Name> Names { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //REMOVED CONNECTION STRING FOR SECURITY PURPOSES
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Name>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
