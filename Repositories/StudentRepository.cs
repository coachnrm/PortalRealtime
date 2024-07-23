using Microsoft.EntityFrameworkCore;
using PortalRealTime.Models;

namespace PortalRealTime.Repositories
{
    public class StudentRepository
    {
        string connectionString;
        private readonly mycontext dbContext;

        public StudentRepository(string connectionString, mycontext _dbContext)
        {
            this.connectionString = connectionString;
            this.dbContext = _dbContext;
        }

        public List<student> GetStudents()
        {
            var studList = dbContext.students.Include(x=>x.Skill).Include(x=>x.Status).ToList();
            foreach (var emp in studList)
            {
                dbContext.Entry(emp).Reload();
            }
            return studList;
        }
    }
}