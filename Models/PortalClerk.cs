using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalRealTime.Models
{
    [Table("PortalClerk")]
    public class PortalClerk
    {
        [Key]
        public int Id { get; set; }
        public string PortalName { get; set; }
    }
}
