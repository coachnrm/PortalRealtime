using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalRealTime.Models
{
    [Table("status")]
    public class status
    {
        [Key]
        public int id {get; set;}
        public string statusname {get; set;}
    }
}