using Microsoft.AspNetCore.SignalR;
using PortalRealTime.Models;
using PortalRealTime.Repositories;

namespace PortalRealTime.Hubs
{
    public class StudentHub : Hub
    {
        StudentRepository studentRepository;
        private readonly mycontext dbContext;
        public StudentHub(IConfiguration configuration, mycontext _dbContext)
        {
            var connectionString = configuration.GetConnectionString("conn");
            dbContext = _dbContext;
            studentRepository = new StudentRepository(connectionString, dbContext);
        }

        public async Task SendStudents()
        {
            var students = studentRepository.GetStudents();
            await Clients.All.SendAsync("ReceivedStudents", students);
        }
    }
}