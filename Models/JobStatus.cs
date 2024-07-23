using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalRealTime.Models
{
    [Table("JobStatus")]
    public class JobStatus
    {
        [Key]
        public int Id { get; set; }
        public string JobStatusName { get; set; }
    }
}
