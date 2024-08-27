using EntityframeworkCoreDay02.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkCoreDay02.Context
{
    internal class AppContextLayer:DbContext
    {
        public AppContextLayer():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connect to DB
            optionsBuilder.UseSqlServer("Server=.;Database=AppContext;Trusted_Connection = True;TrustServerCertificate= True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///modelBuilder.Entity<Employee>(E =>
            ///{
            ///    E.HasKey(e => e.EmpId);
            ///    E.Property(e => e.EmpId).UseIdentityColumn(1, 1);
            ///    E.Property(e => e.Name)
            ///                .HasColumnType("varchar")
            ///                .HasMaxLength(50)
            ///                .IsRequired();
            ///    E.Property(e => e.Salary)
            ///               .HasColumnType("money")
            ///               .IsRequired();
            ///    E.Property(e => e.Address)
            ///              .HasColumnType("varchar")
            ///              .HasMaxLength(50);
            ///});
            modelBuilder.Entity<Employee>(E =>
            {
                E.HasKey(e => e.Id);
                E.Property(e => e.Id).UseIdentityColumn(10, 10);

                E.Property(e => e.Name).HasColumnName("EmpName")
                                     .HasColumnType("varchar")
                                     .HasMaxLength(50)
                                     .IsRequired();
                E.Property(e => e.Salary)
                          .HasColumnType("money")
                          .IsRequired();
            });
            modelBuilder.Entity<Department>(D =>
            {
                D.HasKey(d => d.Id);
                D.Property(d => d.Id).UseIdentityColumn(100, 100);
                D.Property(d => d.DeptName).HasColumnName("DepartmentName")
                .HasColumnType("varchar").HasDefaultValue("Software");
            });
            //modelBuilder.Entity<Employee>(E =>
            //{
            //    E.HasOne(e => e.Department)
            //            .WithOne(d => d.Manager)
            //            .HasForeignKey<Department>(d => d.EmpId);
            //});
            modelBuilder.Entity<Department>(D =>
            {
                D.HasOne(d => d.Manager)
                .WithOne(e => e.Department)
                .HasForeignKey<Department>(d => d.EmpId);
            });
            //modelBuilder.Entity<Department>(D =>
            //{
            //    D.HasMany(d => d.Employees).WithOne(e => e.Workfor).HasForeignKey(d => d.WorkForId);
            //});
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
