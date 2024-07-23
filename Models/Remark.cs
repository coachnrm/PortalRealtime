using System.ComponentModel.DataAnnotations.Schema;

namespace PortalRealTime.Models
{
    [Table("Remark")]
    public class Remark
    {
        public int Id { get; set; }
        public string RemarkName { get; set; }
    }
}
