using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PCVTry.Models
{
    public partial class MVCContext : DbContext
    {
        public MVCContext()
        {
        }

        public MVCContext(DbContextOptions<MVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddiAccess> AddiAccess { get; set; }
        public virtual DbSet<Applicationaccess> Applicationaccess { get; set; }
        public virtual DbSet<BpoRolegroup> BpoRolegroup { get; set; }
        public virtual DbSet<LrvRolegroup> LrvRolegroup { get; set; }
        public virtual DbSet<OtsAccess> OtsAccess { get; set; }
        public virtual DbSet<Requestinfo> Requestinfo { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRequirements> UserRequirements { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }
        public virtual DbSet<VmsRolegroup> VmsRolegroup { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-JD1AN4I\\SQLSERVER;Database=PCV;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddiAccess>(entity =>
            {
                entity.ToTable("addi_access");

                entity.Property(e => e.AddiAccessId)
                    .HasColumnName("AddiAccessID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CopyOf)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Crm).HasColumnName("CRM");

                entity.Property(e => e.Fdic).HasColumnName("FDIC");

                entity.Property(e => e.Pci).HasColumnName("PCI");
            });

            modelBuilder.Entity<Applicationaccess>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("applicationaccess");

                entity.Property(e => e.AppId)
                    .HasColumnName("appID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddAccess).HasColumnName("addAccess");

                entity.Property(e => e.BporoleGroup).HasColumnName("BPORoleGroup");

                entity.Property(e => e.LrvroleGroup).HasColumnName("LRVroleGroup");

                entity.Property(e => e.Mas500Access)
                    .HasColumnName("mas500Access")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Otsaccess).HasColumnName("OTSAccess");

                entity.Property(e => e.VmsroleGroup).HasColumnName("VMSroleGroup");

                entity.HasOne(d => d.AddAccessNavigation)
                    .WithMany(p => p.Applicationaccess)
                    .HasForeignKey(d => d.AddAccess)
                    .HasConstraintName("addi");

                entity.HasOne(d => d.BporoleGroupNavigation)
                    .WithMany(p => p.Applicationaccess)
                    .HasForeignKey(d => d.BporoleGroup)
                    .HasConstraintName("bpo");

                entity.HasOne(d => d.LrvroleGroupNavigation)
                    .WithMany(p => p.Applicationaccess)
                    .HasForeignKey(d => d.LrvroleGroup)
                    .HasConstraintName("lrv");

                entity.HasOne(d => d.OtsaccessNavigation)
                    .WithMany(p => p.Applicationaccess)
                    .HasForeignKey(d => d.Otsaccess)
                    .HasConstraintName("ots");

                entity.HasOne(d => d.VmsroleGroupNavigation)
                    .WithMany(p => p.Applicationaccess)
                    .HasForeignKey(d => d.VmsroleGroup)
                    .HasConstraintName("vms");
            });

            modelBuilder.Entity<BpoRolegroup>(entity =>
            {
                entity.HasKey(e => e.Bpoid);

                entity.ToTable("bpo_rolegroup");

                entity.Property(e => e.Bpoid)
                    .HasColumnName("BPOID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bpoadmin).HasColumnName("BPOAdmin");

                entity.Property(e => e.ContractQc).HasColumnName("ContractQC");

                entity.Property(e => e.FdicQc).HasColumnName("FDIC_QC");

                entity.Property(e => e.QcBasic).HasColumnName("QC_Basic");

                entity.Property(e => e.QcPlus).HasColumnName("QC_Plus");

                entity.Property(e => e.QcSupervisor).HasColumnName("QC_Supervisor");

                entity.Property(e => e.ViewRules).HasColumnName("View_Rules");
            });

            modelBuilder.Entity<LrvRolegroup>(entity =>
            {
                entity.HasKey(e => e.LrvId);

                entity.ToTable("lrv_rolegroup");

                entity.Property(e => e.LrvId)
                    .HasColumnName("LRV_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FannieQc).HasColumnName("FannieQC");

                entity.Property(e => e.LrvAdmin).HasColumnName("LRV_Admin");

                entity.Property(e => e.RegularQc).HasColumnName("RegularQC");
            });

            modelBuilder.Entity<OtsAccess>(entity =>
            {
                entity.ToTable("ots_access");

                entity.Property(e => e.OtsAccessId)
                    .HasColumnName("ots_accessID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Requestinfo>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("requestinfo");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EffectiveEnd)
                    .HasColumnName("effectiveEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.EffectiveStart)
                    .HasColumnName("effectiveStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestByName)
                    .HasColumnName("requestByName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RequestType)
                    .HasColumnName("requestType")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TodayDate)
                    .HasColumnName("today_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserLogId);

                entity.ToTable("user");

                entity.Property(e => e.UserLogId)
                    .HasColumnName("userLog_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRequirements>(entity =>
            {
                entity.HasKey(e => e.UserReqId);

                entity.ToTable("user_requirements");

                entity.Property(e => e.UserReqId)
                    .HasColumnName("userReqID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CubeNum).HasColumnName("cubeNum");

                entity.Property(e => e.DidNum).HasColumnName("didNum");

                entity.Property(e => e.DualMon).HasColumnName("dualMon");

                entity.Property(e => e.FloorNum).HasColumnName("floorNum");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.RemoAcc).HasColumnName("remoAcc");

                entity.Property(e => e.RemoLap).HasColumnName("remoLap");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatus)
                    .HasColumnName("userStatus")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("user_table");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateEnd)
                    .HasColumnName("dateEnd")
                    .HasColumnType("date");

                entity.Property(e => e.DateStart)
                    .HasColumnName("dateStart")
                    .HasColumnType("date");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsManager).HasColumnName("isManager");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerName)
                    .HasColumnName("managerName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Office)
                    .HasColumnName("office")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VmsRolegroup>(entity =>
            {
                entity.ToTable("vms_rolegroup");

                entity.Property(e => e.VmsroleGroupId)
                    .HasColumnName("VMSRoleGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContractorQc).HasColumnName("ContractorQC");

                entity.Property(e => e.Itgroup).HasColumnName("ITGroup");

                entity.Property(e => e.Qc).HasColumnName("QC");

                entity.Property(e => e.QcsupervisorLead).HasColumnName("QCSupervisorLead");
            });
        }
    }
}
