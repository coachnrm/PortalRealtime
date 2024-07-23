using Microsoft.EntityFrameworkCore;
using PortalRealTime.Models;

namespace PortalRealTime.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<NurseRequest> NurseRequests { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PortalCarType> PortalCarTypes { get; set; }
        public DbSet<UrgencyType> UrgencyTypes { get; set; }
        public DbSet<PortalClerk> PortalClerks { get; set; }
        public DbSet<JobStatus> JobStatuses { get; set; }
        public DbSet<Remark> Remarks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1,
                    DepartmentName = "OPD อายุรกรรม"
                },
                new Department
                {
                    Id = 2,
                    DepartmentName = "OPD ศัลยกรรม"
                },
                new Department
                {
                    Id = 3,
                    DepartmentName = "ห้องเจาะเลือด"
                },
                new Department
                {
                    Id = 4,
                    DepartmentName = "ห้อง x-ray"
                }
            );
            modelBuilder.Entity<PortalCarType>().HasData(
               new PortalCarType
               {
                   Id = 1,
                   PortalCarName = "รถนั่ง"
               },
               new PortalCarType
               {
                   Id = 2,
                   PortalCarName = "รถนอน"
               }
           );
            modelBuilder.Entity<UrgencyType>().HasData(
               new UrgencyType
               {
                   Id = 1,
                   UrgencyName = "ปกติ"
               },
               new UrgencyType
               {
                   Id = 2,
                   UrgencyName = "ด่วน"
               },
               new UrgencyType
               {
                   Id = 3,
                   UrgencyName = "ด่วนมาก"
               }
           );
            modelBuilder.Entity<PortalClerk>().HasData(
               new PortalClerk
               {
                   Id = 1,
                   PortalName = "รณรงค์ มาลามาศ"
               },
               new PortalClerk
               {
                   Id = 2,
                   PortalName = "กิตติ ภูมิบูรณ์"
               }
           );
            modelBuilder.Entity<JobStatus>().HasData(
              new JobStatus
              {
                  Id = 1,
                  JobStatusName = "ร้องขอ"
              },
              new JobStatus
              {
                  Id = 2,
                  JobStatusName = "จ่ายงาน"
              },
              new JobStatus
              {
                  Id = 3,
                  JobStatusName = "กำลังเดินทาง"
              },
              new JobStatus
              {
                  Id = 4,
                  JobStatusName = "การบริการเสร็จสิ้น"
              }
          );
            modelBuilder.Entity<Remark>().HasData(
              new Remark
              {
                  Id = 1,
                  RemarkName = "ผู้ป่วยติดเชื้อ"
              },
              new Remark
              {
                  Id = 2,
                  RemarkName = "ผู้ป่วยอ้วน ขอเวรเปล 2 คน"
              }
          );
        }
    }
}
