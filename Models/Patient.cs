using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Patient : AuditModel
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal Age { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
