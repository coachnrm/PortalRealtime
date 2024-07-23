using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalRealTime.Models
{
    [Table("UrgencyType")]
    public class UrgencyType
    {
        [Key]
        public int Id { get; set; }
        public string UrgencyName { get; set; }
    }
}
