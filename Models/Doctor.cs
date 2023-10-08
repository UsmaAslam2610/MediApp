using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Doctor : AuditModel
    {
        public Doctor()
        {
            DoctorSchedules = new HashSet<DoctorSchedule>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Qualification { get; set; } = null!;
        public string ExpertIn { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string DateAdded { get; set; } = null!;

        public virtual ICollection<DoctorSchedule> DoctorSchedules { get; set; }
    }
}
