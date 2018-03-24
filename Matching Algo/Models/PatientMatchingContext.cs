using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MatchingAlgoModels
{
    public partial class PatientMatchingContext : DbContext
    {
        public virtual DbSet<Person> Person { get; set; }

        // Unable to generate entity type for table 'dbo.data'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-L5E8TTGS;Initial Catalog=PatientMatching;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("company_name")
                    .HasMaxLength(50);

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasColumnName("county")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasColumnName("phone1")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasColumnName("phone2")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.Web)
                    .IsRequired()
                    .HasColumnName("web")
                    .HasMaxLength(50);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasMaxLength(50);
            });
        }
    }
}
