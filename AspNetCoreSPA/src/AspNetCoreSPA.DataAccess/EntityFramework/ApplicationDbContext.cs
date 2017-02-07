using Microsoft.EntityFrameworkCore;
using AspNetCoreSPA.Model.POCOs;

namespace AspNetCoreSPA.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Country> Country { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_STATE_OF_ORIGIN");

                entity.ToTable("COUNTRY");

                entity.Property(e => e.Id)
                    .HasColumnName("ST_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameEN)
                    .IsRequired()
                    .HasColumnName("ST_NAME_EN")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NameRS)
                    .IsRequired()
                    .HasColumnName("ST_NAME_SRB")
                    .HasColumnType("varchar(30)");
            });
        }
    }
}
