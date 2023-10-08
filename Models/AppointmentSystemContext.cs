using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Project.Models
{
    public partial class AppointmentSystemContext : DbContext //IdentityDbContext<Customor>
    {
        public AppointmentSystemContext()
        {
        }

        public AppointmentSystemContext(DbContextOptions<AppointmentSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<DoctorSchedule> DoctorSchedules { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public override int SaveChanges()
        {
            var tracker = ChangeTracker;
            foreach (var entry in tracker.Entries())
            {
                if (entry.Entity is AuditModel)
                {
                        var referenceEntity = entry.Entity as AuditModel;
                        switch (entry.State)
                        {
                            case EntityState.Added:
                                referenceEntity.CreatedDate = DateTime.Now.ToString("dd/MM/yyyy");
                                referenceEntity.IsActive = true;
                                referenceEntity.IsDeleted = false;
                                break;
                            case EntityState.Deleted:
                                referenceEntity.IsDeleted = true;
                                referenceEntity.IsActive = false;
                                referenceEntity.LastModifiedDate = DateTime.Now.ToString("dd/MM/yyyy");
                                break;
                            case EntityState.Modified:
                                referenceEntity.LastModifiedDate = DateTime.Now.ToString("dd/MM/yyyy");
                                break;
                            default:
                                break;
                        }
                    
                }
            }
            return base.SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppointmentSystem");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.HasIndex(e => e.Email, "UQ__Admin__A9D10534D60B2E07")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.DoctorComment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doctor_comment");

                entity.Property(e => e.DoctorScheduleId).HasColumnName("doctor_schedule_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.DoctorSchedule)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DoctorScheduleId)
                    .HasConstraintName("FK__Appointme__docto__32E0915F");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__Appointme__patie__33D4B598");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor");

                entity.HasIndex(e => e.Email, "UQ__Doctor__A9D10534E4F309F5")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Date_Added");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpertIn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Expert_In");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DoctorSchedule>(entity =>
            {
                entity.ToTable("doctor_Schedule");

                entity.Property(e => e.AverageConsultingTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("average_consulting_time");

                entity.Property(e => e.DoctorId).HasColumnName("doctor_id");

                entity.Property(e => e.DoctorScheduleDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doctor_schedule_date");

                entity.Property(e => e.DoctorScheduleDay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doctor_schedule_day");

                entity.Property(e => e.DoctorScheduleEndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doctor_schedule_end_time");

                entity.Property(e => e.DoctorScheduleStartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doctor_schedule_start_time");

                entity.Property(e => e.ScheduleStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("schedule_status");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorSchedules)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__doctor_Sc__docto__2E1BDC42");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.HasIndex(e => e.Email, "UQ__Patient__A9D10534D6C462D9")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
