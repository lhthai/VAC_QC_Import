using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ImportDimensionCheck.Models
{
    public partial class VACP4DBContext : DbContext
    {
        public VACP4DBContext()
        {
        }

        public VACP4DBContext(DbContextOptions<VACP4DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BatchCode> BatchCode { get; set; }
        public virtual DbSet<BatchCodeActivity> BatchCodeActivity { get; set; }
        public virtual DbSet<BatchCodeHis> BatchCodeHis { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<QC> QC { get; set; }
        public virtual DbSet<QCDetail> QCDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-P8OGV6L\\SQLEXPRESS;Database=VACP4DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BatchCode>(entity =>
            {
                entity.HasKey(e => new { e.Product, e.BatchCode1 });

                entity.Property(e => e.Product).HasMaxLength(50);

                entity.Property(e => e.BatchCode1)
                    .HasColumnName("BatchCode")
                    .HasMaxLength(36);

                entity.Property(e => e.Allocated).HasMaxLength(1);

                entity.Property(e => e.AllocatedNote).HasMaxLength(255);

                entity.Property(e => e.Area).HasMaxLength(25);

                entity.Property(e => e.BOMNo).HasMaxLength(60);

                entity.Property(e => e.BatchCodeSts).HasMaxLength(1);

                entity.Property(e => e.BinLocation).HasMaxLength(100);

                entity.Property(e => e.BlockBy).HasMaxLength(10);

                entity.Property(e => e.BlockDate).HasColumnType("datetime");

                entity.Property(e => e.BlockReason).HasMaxLength(50);

                entity.Property(e => e.Blocked).HasMaxLength(1);

                entity.Property(e => e.BoxNo).HasMaxLength(25);

                entity.Property(e => e.CONO).HasMaxLength(20);

                entity.Property(e => e.CauseNote).HasMaxLength(255);

                entity.Property(e => e.CauseReason).HasMaxLength(50);

                entity.Property(e => e.ChangeBy).HasMaxLength(10);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ChangePatch).HasMaxLength(10);

                entity.Property(e => e.CheckBy).HasMaxLength(10);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckPeriod).HasMaxLength(1);

                entity.Property(e => e.Checked).HasMaxLength(1);

                entity.Property(e => e.CreateBy).HasMaxLength(10);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CurEmp).HasMaxLength(10);

                entity.Property(e => e.CurEquipment).HasMaxLength(20);

                entity.Property(e => e.CurFinish).HasColumnType("datetime");

                entity.Property(e => e.CurMC).HasMaxLength(25);

                entity.Property(e => e.CurOprCode).HasMaxLength(10);

                entity.Property(e => e.CurOprDesc).HasMaxLength(255);

                entity.Property(e => e.CurOprSts).HasMaxLength(1);

                entity.Property(e => e.CurStart).HasColumnType("datetime");

                entity.Property(e => e.CurStation).HasMaxLength(25);

                entity.Property(e => e.CurWC)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurWO).HasMaxLength(10);

                entity.Property(e => e.DamageBy).HasMaxLength(10);

                entity.Property(e => e.DamageDate).HasColumnType("datetime");

                entity.Property(e => e.DamageNote).HasMaxLength(255);

                entity.Property(e => e.Damaged).HasMaxLength(1);

                entity.Property(e => e.DefectBy).HasMaxLength(10);

                entity.Property(e => e.DefectDate).HasColumnType("datetime");

                entity.Property(e => e.DefectNote).HasMaxLength(255);

                entity.Property(e => e.DefectReason).HasMaxLength(110);

                entity.Property(e => e.DefectSts).HasMaxLength(1);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.InStock).HasMaxLength(1);

                entity.Property(e => e.MainWONO).HasMaxLength(10);

                entity.Property(e => e.NextOprCode).HasMaxLength(10);

                entity.Property(e => e.NextOprDesc).HasMaxLength(255);

                entity.Property(e => e.Plant).HasMaxLength(3);

                entity.Property(e => e.PrintBy).HasMaxLength(10);

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.Printed).HasMaxLength(1);

                entity.Property(e => e.ProductDesc).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.ReceiptBy).HasMaxLength(10);

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.Received).HasMaxLength(1);

                entity.Property(e => e.RecoverBy).HasMaxLength(10);

                entity.Property(e => e.RecoverDate).HasColumnType("datetime");

                entity.Property(e => e.RecoverNote).HasMaxLength(255);

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.RestoreBy).HasMaxLength(10);

                entity.Property(e => e.RestoreDate).HasColumnType("datetime");

                entity.Property(e => e.RestoreNote).HasMaxLength(255);

                entity.Property(e => e.Rework).HasMaxLength(1);

                entity.Property(e => e.ReworkBy).HasMaxLength(10);

                entity.Property(e => e.ReworkDate).HasColumnType("datetime");

                entity.Property(e => e.ReworkMC).HasMaxLength(25);

                entity.Property(e => e.ReworkNote).HasMaxLength(255);

                entity.Property(e => e.ReworkOprCode).HasMaxLength(10);

                entity.Property(e => e.ReworkOprDesc).HasMaxLength(255);

                entity.Property(e => e.ReworkStation).HasMaxLength(25);

                entity.Property(e => e.SaveBy).HasMaxLength(10);

                entity.Property(e => e.SaveDate).HasColumnType("datetime");

                entity.Property(e => e.SmallBoxNo).HasMaxLength(25);

                entity.Property(e => e.UOM).HasMaxLength(10);

                entity.Property(e => e.Verified).HasMaxLength(1);

                entity.Property(e => e.VerifiedNote).HasMaxLength(255);

                entity.Property(e => e.WH).HasMaxLength(8);

                entity.Property(e => e.WgtSts).HasMaxLength(10);

                entity.Property(e => e.WorkStation).HasMaxLength(25);

                entity.Property(e => e.Zone).HasMaxLength(8);
            });

            modelBuilder.Entity<BatchCodeActivity>(entity =>
            {
                entity.HasKey(e => new { e.Product, e.BatchCode, e.Seq });

                entity.Property(e => e.Product).HasMaxLength(50);

                entity.Property(e => e.BatchCode).HasMaxLength(36);

                entity.Property(e => e.Area).HasMaxLength(25);

                entity.Property(e => e.ChangeBy).HasMaxLength(10);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ChangeNote).HasMaxLength(255);

                entity.Property(e => e.ChangeTime).HasColumnType("datetime");

                entity.Property(e => e.CreateBy).HasMaxLength(10);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmpCode).HasMaxLength(10);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.LinkFile).HasMaxLength(255);

                entity.Property(e => e.MC).HasMaxLength(25);

                entity.Property(e => e.Station).HasMaxLength(25);

                entity.Property(e => e.SysNote).HasMaxLength(255);

                entity.Property(e => e.TransType).HasMaxLength(250);

                entity.Property(e => e.WONO).HasMaxLength(10);

                entity.Property(e => e.WorkStation).HasMaxLength(25);
            });

            modelBuilder.Entity<BatchCodeHis>(entity =>
            {
                entity.HasKey(e => new { e.Product, e.BatchCode, e.HisSeq });

                entity.Property(e => e.Product).HasMaxLength(50);

                entity.Property(e => e.BatchCode).HasMaxLength(36);

                entity.Property(e => e.Area).HasMaxLength(25);

                entity.Property(e => e.ChangeBy).HasMaxLength(10);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ChangeNote).HasMaxLength(255);

                entity.Property(e => e.CreateBy).HasMaxLength(10);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmpCode).HasMaxLength(25);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.LinkFile).HasMaxLength(255);

                entity.Property(e => e.MC).HasMaxLength(25);

                entity.Property(e => e.MainWONO).HasMaxLength(10);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Station).HasMaxLength(25);

                entity.Property(e => e.SysNote).HasMaxLength(255);

                entity.Property(e => e.TransType).HasMaxLength(25);

                entity.Property(e => e.WONO).HasMaxLength(10);

                entity.Property(e => e.WorkStation).HasMaxLength(25);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => new { e.Employee1, e.WC });

                entity.Property(e => e.Employee1)
                    .HasColumnName("Employee")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WC)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ChangeBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmpGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeePWD)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsMA)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsQC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasKey(e => e.Machine1)
                    .IsClustered(false);

                entity.Property(e => e.Machine1)
                    .HasColumnName("Machine")
                    .HasMaxLength(25);

                entity.Property(e => e.Area).HasMaxLength(25);

                entity.Property(e => e.CC2).HasMaxLength(8);

                entity.Property(e => e.CC3).HasMaxLength(8);

                entity.Property(e => e.CC4).HasMaxLength(8);

                entity.Property(e => e.CC5).HasMaxLength(8);

                entity.Property(e => e.ChangeBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CostCenter).HasMaxLength(8);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DLBACC).HasMaxLength(15);

                entity.Property(e => e.DOHACC).HasMaxLength(15);

                entity.Property(e => e.ILBACC).HasMaxLength(15);

                entity.Property(e => e.IOHACC).HasMaxLength(15);

                entity.Property(e => e.IRMACC).HasMaxLength(15);

                entity.Property(e => e.IsParallel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsPlan)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ItemBindType).HasMaxLength(100);

                entity.Property(e => e.ItemColorType).HasMaxLength(100);

                entity.Property(e => e.ItemPart).HasMaxLength(100);

                entity.Property(e => e.ItemSize).HasMaxLength(100);

                entity.Property(e => e.ItemTurnType).HasMaxLength(100);

                entity.Property(e => e.LastStartTime).HasColumnType("date");

                entity.Property(e => e.MachineGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineMgr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(100);

                entity.Property(e => e.PMStaffs).HasMaxLength(255);

                entity.Property(e => e.ParallelCond)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.RouteMethod)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Station).HasMaxLength(10);

                entity.Property(e => e.WC)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WH)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zone).HasMaxLength(8);
            });

            modelBuilder.Entity<QC>(entity =>
            {
                entity.HasKey(e => e.QCNO);

                entity.Property(e => e.QCNO)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AutoOpenQC).HasMaxLength(10);

                entity.Property(e => e.BOMNo).HasMaxLength(60);

                entity.Property(e => e.BatchNo).HasMaxLength(36);

                entity.Property(e => e.ChangeBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FPGrade).HasMaxLength(10);

                entity.Property(e => e.Grade).HasMaxLength(10);

                entity.Property(e => e.InspectionDesc).HasMaxLength(255);

                entity.Property(e => e.Location)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MFRDate).HasColumnType("datetime");

                entity.Property(e => e.OperationCode).HasMaxLength(25);

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductDesc).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.ProductionLot).HasMaxLength(25);

                entity.Property(e => e.QCBy).HasMaxLength(10);

                entity.Property(e => e.QCDate).HasColumnType("datetime");

                entity.Property(e => e.QCNote).HasMaxLength(255);

                entity.Property(e => e.QCStatus)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.QCType)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Reason).HasMaxLength(5);

                entity.Property(e => e.ReasonName).HasMaxLength(50);

                entity.Property(e => e.RefDoc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RefInfo).HasMaxLength(255);

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.ScreenType).HasMaxLength(10);

                entity.Property(e => e.ToWH)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.UOM).HasMaxLength(10);

                entity.Property(e => e.WH)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QCDetail>(entity =>
            {
                entity.HasKey(e => new { e.QCNO, e.Product, e.QCCode, e.QCSeq })
                    .HasName("PK_QCDetail_1");

                entity.Property(e => e.QCNO)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Product).HasMaxLength(20);

                entity.Property(e => e.QCCode).HasMaxLength(20);

                entity.Property(e => e.BatchCode).HasMaxLength(36);

                entity.Property(e => e.ChangeBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CheckBy).HasMaxLength(10);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.InspectType).HasMaxLength(25);

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.QCGroup).HasMaxLength(20);

                entity.Property(e => e.RSTS1).HasMaxLength(50);

                entity.Property(e => e.RSTS2).HasMaxLength(50);

                entity.Property(e => e.RSTS3).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(10);

                entity.Property(e => e.SpecType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Station).HasMaxLength(25);

                entity.Property(e => e.TestMethod).HasMaxLength(20);

                entity.Property(e => e.ToolID).HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
