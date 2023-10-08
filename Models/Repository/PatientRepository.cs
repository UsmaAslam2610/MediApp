namespace Project.Models.Repository;
using Project.Models.Interfaces;
using Project.Models.ViewModel;
public class PatientRepository: IPatient
    {
        public bool checkPatientExist(string email)
        {
            var db = new AppointmentSystemContext();
            return db.Patients.Any(a => a.Email == email);
        }
        public bool validatePass(string Email, string Password)
        {
            var db = new AppointmentSystemContext();
            return db.Patients.Any(a => a.Email == Email && a.Password == Password);
        }
        public bool addPatient(Patient pa)
        {
            var db = new AppointmentSystemContext();
            if (checkPatientExist(pa.Email))
                return false;
            else
            {
                db.Patients.Add(pa);
                db.SaveChanges();
                return true;
            }
        }
    public Patient getPat(string Email)
    {
        var db = new AppointmentSystemContext();
        Patient obj = db.Patients.First(a => a.Email == Email);
        return obj;
    }
    public bool DelAppointments(int Id)
    {
        var db = new AppointmentSystemContext();
        Appointment app = db.Appointments.First(a => a.Id == Id);
        db.Appointments.Remove(app);
        if (db.SaveChanges() != 0)
            return true;
        else
            return false;
    }
    public List<Appointment> getPatientAppo(string email)
    {
        var db = new AppointmentSystemContext();
        int id = getPat(email).Id;
        List<Appointment> appointments = db.Appointments.Where(a=>a.PatientId == id).ToList();
        return appointments;
    }
    public List<UserAppointments> GetUserAppointments(string email)
    {
        List<Appointment> appointments = getPatientAppo(email);
        List<UserAppointments> AppList = new List<UserAppointments>();
        foreach (Appointment ele in appointments)
        {
            DoctorRepository docRepo = new DoctorRepository();
            DoctorSchedule docsch = docRepo.getDocSchedule(ele.DoctorScheduleId);
            Doctor doc = docRepo.getDoc(docsch.DoctorId);
            UserAppointments uApp = new UserAppointments() { appNo = ele.Id, DocName = doc.Name, AppTime = docsch.DoctorScheduleStartTime, AppDate = docsch.DoctorScheduleDate, AppDay = docsch.DoctorScheduleDay, AppStatus = ele.Status };
            AppList.Add(uApp);
        }
        return AppList;
    }
}

