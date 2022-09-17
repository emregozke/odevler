using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Models
{
    public partial class KonuOdevDBContext : DbContext
    {
        public KonuOdevDBContext()
        {
        }

        public KonuOdevDBContext(DbContextOptions<KonuOdevDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Konu> Konus { get; set; }
        public virtual DbSet<Ogrenci> Ogrencis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-HBSN76P;database=KonuOdevDB;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Konu>(entity =>
            {
                entity.ToTable("Konu");

                entity.Property(e => e.KonuAdi)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ogrenci>(entity =>
            {
                entity.ToTable("Ogrenci");

                entity.Property(e => e.AnlatimTarihi).HasColumnType("datetime");

                entity.Property(e => e.OgrenciAd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("OgrenciAD");

                entity.Property(e => e.OgrenciSoyad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Konu)
                    .WithMany(p => p.Ogrencis)
                    .HasForeignKey(d => d.KonuId)
                    .HasConstraintName("FK_Ogrenci_Konu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
