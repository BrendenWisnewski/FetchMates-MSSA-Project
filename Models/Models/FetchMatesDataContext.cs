using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FetchMates.Models
{
    public partial class FetchMatesDataContext : DbContext
    {
        public FetchMatesDataContext()
        {
        }

        public FetchMatesDataContext(DbContextOptions<FetchMatesDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dog> Dogs { get; set; }
        public virtual DbSet<DogParkVisit> DogParkVisits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=FetchMatesData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dog>(entity =>
            {
                entity.Property(e => e.DogId).HasColumnName("DogID");

                entity.Property(e => e.DogBreed)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dog Breed");

                entity.Property(e => e.DogName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Dog Name");

                entity.Property(e => e.DogWeight).HasColumnName("Dog Weight");
            });

            modelBuilder.Entity<DogParkVisit>(entity =>
            {
                entity.HasKey(e => e.DogId)
                    .HasName("PK__DogParkV__46F46EC9F272B254");

                entity.Property(e => e.DogId)
                    .ValueGeneratedNever()
                    .HasColumnName("DogID");

                entity.Property(e => e.DayAndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Day And Time");

                entity.Property(e => e.ParkName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Park Name");

                entity.HasOne(d => d.Dog)
                    .WithOne(p => p.DogParkVisit)
                    .HasForeignKey<DogParkVisit>(d => d.DogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Dog");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
