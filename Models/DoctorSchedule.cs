using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class DoctorSchedule : AuditModel
    {
        public DoctorSchedule()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string DoctorScheduleDate { get; set; } = null!;
        public string DoctorScheduleDay { get; set; } = null!;
        public string DoctorScheduleStartTime { get; set; } = null!;
        public string DoctorScheduleEndTime { get; set; } = null!;
        public string AverageConsultingTime { get; set; } = null!;
        public string ScheduleStatus { get; set; } = null!;

        public virtual Doctor Doctor { get; set; } = null!;
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
