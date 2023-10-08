using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public partial class Admin : AuditModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
