using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DiplomWPF.Models
{
    public partial class RZDDatabaseContext : DbContext
    {
        public static RZDDatabaseContext db = GetContext();
        private static RZDDatabaseContext _context;
        public RZDDatabaseContext()
        {
        }

        public RZDDatabaseContext(DbContextOptions<RZDDatabaseContext> options)
            : base(options)
        {
        }
        
        public static RZDDatabaseContext GetContext()
        {
            if (_context == null) 
                _context = new RZDDatabaseContext();
            return _context;
        }

        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<JobName> JobNames { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<SystemAdministrator> SystemAdministrators { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseNpgsql("Host=localhost;Port=5432;Database=RZDDatabase;Username=postgres;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cost>(entity =>
            {
                entity.ToTable("cost");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("history");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdWorker).HasColumnName("Id_Worker");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdWorkerNavigation)
                    .WithMany(p => p.History)
                    .HasForeignKey(d => d.IdWorker)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_history_worker");
            });

            modelBuilder.Entity<JobName>(entity =>
            {
                entity.ToTable("jobName");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("report");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.Costs).HasColumnType("money");

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("request");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.DateOfCreation).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.IdStatus).HasColumnName("Id_Status");

                entity.Property(e => e.IdType).HasColumnName("Id_Type");

                entity.Property(e => e.IdWorker).HasColumnName("Id_Worker");

                entity.Property(e => e.Post)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_request_status");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_request_type");

                entity.HasOne(d => d.IdWorkerNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.IdWorker)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_request_worker");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<SystemAdministrator>(entity =>
            {
                entity.HasKey(e => e.IdJobName)
                    .HasName("SystemAdministrator_pkey");

                entity.ToTable("systemAdministrator");

                entity.Property(e => e.IdJobName)
                    .HasColumnName("Id_JobName")
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Login).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Surname).HasMaxLength(100);

                entity.HasOne(d => d.IdJobNameNavigation)
                    .WithOne(p => p.SystemAdministrator)
                    .HasForeignKey<SystemAdministrator>(d => d.IdJobName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_systemAdministrator_jobName");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("type");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("worker");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.Cabinet)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Patronymic).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
