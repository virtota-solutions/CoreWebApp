using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PCVMurcorWebApp.Models
{
    public partial class VirtotaSolutionsContext : DbContext
    {
        public VirtotaSolutionsContext()
        {
        }

        public VirtotaSolutionsContext(DbContextOptions<VirtotaSolutionsContext> options)
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
                optionsBuilder.UseSqlServer("VSDatabase");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

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
                entity.HasKey(e => e.UserId)
                    .HasName("PK__applicat__CB9A1CDFCF85E4ED");

                entity.ToTable("applicationaccess");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
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

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Applicationaccess)
                    .HasForeignKey<Applicationaccess>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("applicationaccess_ibfk_1");

                entity.HasOne(d => d.VmsroleGroupNavigation)
                    .WithMany(p => p.Applicationaccess)
                    .HasForeignKey(d => d.VmsroleGroup)
                    .HasConstraintName("vms");
            });

            modelBuilder.Entity<BpoRolegroup>(entity =>
            {
                entity.HasKey(e => e.Bpoid)
                    .HasName("PK__bpo_role__E45A873852E0E4A7");

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
                entity.HasKey(e => e.LrvId)
                    .HasName("PK__lrv_role__1D43909DE8384D63");

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
                entity.HasKey(e => e.UserId)
                    .HasName("PK__requesti__B9BF3307E59E833B");

                entity.ToTable("requestinfo");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_ID")
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

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Requestinfo)
                    .HasForeignKey<Requestinfo>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_ID")
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

                entity.HasOne(d => d.UserNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_ID");
            });

            modelBuilder.Entity<UserRequirements>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__user_req__CB9A1CDF798DD79A");

                entity.ToTable("user_requirements");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
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

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserRequirements)
                    .HasForeignKey<UserRequirements>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_requirements_ibfk_1");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__user_tab__CB9A1CDF5BDF6314");

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
