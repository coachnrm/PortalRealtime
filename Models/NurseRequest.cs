using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalRealTime.Models
{
    [Table("NurseRequest")]
    public class NurseRequest
    {
        [Key]
        public int JobId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string? Hn { get; set; }
        public int StartPointId { get; set; } = 1;
        [ForeignKey("StartPointId")]
        public virtual Department StartDepartment { get; set; }
        public int EndPointId { get; set; } = 1;
        [ForeignKey("EndPointId")]
        public virtual Department EndDepartment { get; set; }
        public int PortalCarTypeId { get; set; } = 1;
        [ForeignKey("PortalCarTypeId")]
        public virtual PortalCarType PortalCarType { get; set; }
        public int UrgencyTypeId { get; set; } = 1;
        [ForeignKey("UrgencyTypeId")]
        public virtual UrgencyType UrgencyType { get; set; }
        public int PortalNameId { get; set; } = 1;
        [ForeignKey("PortalNameId")]
        public virtual PortalClerk PortalName { get; set; }
        public int JobStatusId { get; set; } = 1;
        [ForeignKey("JobStatusId")]
        public virtual JobStatus JobStatus { get; set; }
        public int RemarkId { get; set; } = 1;
        [ForeignKey("RemarkId")]
        public virtual Remark Remark { get; set; }
    }
}
