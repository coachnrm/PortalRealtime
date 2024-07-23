using Microsoft.EntityFrameworkCore;

namespace PortalRealTime.Models
{
    public class mycontext:DbContext
    {
        public mycontext(DbContextOptions options):base(options)
        {

        }
        public DbSet<skill> skills {get; set;}
        public DbSet<status> statuses {get; set;}
        public DbSet<student> students {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<skill>().HasData(
                new skill
                {
                    id = 1,
                    skillname = "php"
                },
                new skill
                {
                    id = 2,
                    skillname = "python"
                }
            );
            modelBuilder.Entity<status>().HasData(
                new status
                {
                    id = 1,
                    statusname = "wait for transfer"
                },
                new status
                {
                    id = 2,
                    statusname = "delivery"
                }
            );
            modelBuilder.Entity<skill>()
                .ToTable(tb => tb.UseSqlOutputClause(false));
            modelBuilder.Entity<status>()
                .ToTable(tb => tb.UseSqlOutputClause(false));
             modelBuilder.Entity<student>()
                .ToTable(tb => tb.UseSqlOutputClause(false));
            base.OnModelCreating(modelBuilder);
        }
    }
}