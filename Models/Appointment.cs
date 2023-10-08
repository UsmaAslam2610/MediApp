using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Appointment : AuditModel
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorScheduleId { get; set; }
        public string Reason { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string DoctorComment { get; set; } = null!;

        public virtual DoctorSchedule DoctorSchedule { get; set; } = null!;
        public virtual Patient Patient { get; set; } = null!;
    }
}
