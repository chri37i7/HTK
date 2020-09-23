using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HTKKlub.Entities;

#nullable disable

namespace HTKKlub.Entities.Models
{
    public partial class HtkDbContext : DbContext
    {
        public HtkDbContext()
        {
        }

        public HtkDbContext(DbContextOptions<HtkDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Court> Courts { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Ranking> Rankings { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HtkKlubDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Court>(entity =>
            {
                entity.HasKey(e => e.PkCourtId);

                entity.Property(e => e.PkCourtId).HasColumnName("PK_CourtId");

                entity.Property(e => e.CourtName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.PkMemberId);

                entity.Property(e => e.PkMemberId).HasColumnName("PK_MemberId");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Birthdate)
                    .HasColumnType("datetime")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Ranking>(entity =>
            {
                entity.HasKey(e => e.PkRankId);

                entity.Property(e => e.PkRankId).HasColumnName("PK_RankId");

                entity.Property(e => e.FkMemberId).HasColumnName("FK_MemberId");

                entity.HasOne(d => d.FkMember)
                    .WithMany(p => p.Rankings)
                    .HasForeignKey(d => d.FkMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rankings_Member");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.PkReservationId);

                entity.Property(e => e.PkReservationId).HasColumnName("PK_ReservationId");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.FkCourtId).HasColumnName("FK_CourtId");

                entity.Property(e => e.FkFirstMember).HasColumnName("FK_FirstMember");

                entity.Property(e => e.FkSecondMember).HasColumnName("FK_SecondMember");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.HasOne(d => d.FkCourt)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.FkCourtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservations_Court");

                entity.HasOne(d => d.FkFirstMemberNavigation)
                    .WithMany(p => p.ReservationFkFirstMemberNavigations)
                    .HasForeignKey(d => d.FkFirstMember)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservations_FirstMember");

                entity.HasOne(d => d.FkSecondMemberNavigation)
                    .WithMany(p => p.ReservationFkSecondMemberNavigations)
                    .HasForeignKey(d => d.FkSecondMember)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservations_SecondMember");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
