using PortalRealTime.Hubs;
using PortalRealTime.Models;
using TableDependency.SqlClient;

namespace PortalRealTime.SubscribeTableDependencies
{
    public class SubscribeStudentTableDependency : ISubscribeTableDependency
    {
        SqlTableDependency<student> tableDependency;
        StudentHub studentHub;
        public SubscribeStudentTableDependency(StudentHub studentHub)
        {
            this.studentHub = studentHub;
        }

        public void SubscribeTableDependency(string connectionString)
        {
            tableDependency = new SqlTableDependency<student>(connectionString);
            tableDependency.OnChanged += TableDependency_OnChanged;
            tableDependency.OnError += TableDependency_OnError;
            tableDependency.Start();
        }

        private async void TableDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<student> e)
        {
            if (e.ChangeType != TableDependency.SqlClient.Base.Enums.ChangeType.None)
            {
                await studentHub.SendStudents();
            }
        }


        private void TableDependency_OnError(object sender, TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
        {
            Console.WriteLine($"{nameof(student)} SqlTableDependency error: {e.Error.Message}");
        }
    }
}