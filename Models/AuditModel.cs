using Project.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
    public abstract class AuditModel : IAuditModel
    {
        public string? CreatedDate { get; set; }
        public string? LastModifiedDate { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

    }
}
