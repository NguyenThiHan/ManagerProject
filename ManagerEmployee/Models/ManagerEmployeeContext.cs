using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ManagerEmployee.Models
{
    public partial class ManagerEmployeeContext : DbContext
    {
        public ManagerEmployeeContext()
        {
        }

        public ManagerEmployeeContext(DbContextOptions<ManagerEmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<EmpDep> EmpDep { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=AITD201904003;Database=ManagerEmployee;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.IdDepartment);

                entity.Property(e => e.IdDepartment)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.NameDepartment)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmpDep>(entity =>
            {
                entity.HasKey(e => new { e.IdEmployee, e.IdDepartment });

                entity.ToTable("Emp_Dep");

                entity.Property(e => e.IdEmployee).HasMaxLength(50);

                entity.Property(e => e.IdDepartment).HasMaxLength(50);

                entity.HasOne(d => d.IdDepartmentNavigation)
                    .WithMany(p => p.EmpDep)
                    .HasForeignKey(d => d.IdDepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Emp_Dep_Department");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.EmpDep)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Emp_Dep_Employee");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.Property(e => e.IdEmployee)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateofBirth).HasColumnType("date");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdPosition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdPositionNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.IdPosition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Position");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.IdPosition);

                entity.Property(e => e.IdPosition)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.NamePosition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.IdEmployeee)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdEmployeeeNavigation)
                    .WithMany(p => p.UserLogin)
                    .HasForeignKey(d => d.IdEmployeee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLogin_Employee");
            });
        }
    }
}
