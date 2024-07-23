using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalRealTime.Models
{
    [Table("PortalCarType")]
    public class PortalCarType
    {
        [Key]
        public int Id { get; set; }
        public string PortalCarName { get; set; }
    }
}
