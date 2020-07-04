using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ImportDimensionCheck.Models
{
    public partial class VACP4DBContext : DbContext
    {
        ConnectionString conn = new ConnectionString();
        public VACP4DBContext()
        {
        }

        public VACP4DBContext(DbContextOptions<VACP4DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserMasterDTO> UserMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer($"Server=DESKTOP-P8OGV6L\\SQLEXPRESS;Database={conn.DBName};Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMasterDTO>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10);

                entity.Property(e => e.ChangeBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Dept).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(5);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(20);

                entity.Property(e => e.Lang).HasMaxLength(2);

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.NotInFromDate).HasColumnType("datetime");

                entity.Property(e => e.NotInToDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PlanGroup).HasMaxLength(10);

                entity.Property(e => e.PlantAcb)
                    .HasColumnName("PlantACB")
                    .HasMaxLength(255);

                entity.Property(e => e.QueryAcb)
                    .HasColumnName("QueryACB")
                    .HasMaxLength(255);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.SapPassword)
                    .HasColumnName("sapPassword")
                    .HasMaxLength(50);

                entity.Property(e => e.SapUser)
                    .HasColumnName("sapUser")
                    .HasMaxLength(50);

                entity.Property(e => e.UserGroupId)
                    .HasColumnName("UserGroupID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserType).HasMaxLength(10);

                entity.Property(e => e.Wcacb)
                    .HasColumnName("WCACB")
                    .HasMaxLength(255);

                entity.Property(e => e.Whacb)
                    .HasColumnName("WHACB")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
