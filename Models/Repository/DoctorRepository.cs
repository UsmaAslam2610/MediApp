using System;
using System.Linq;
using Project.Models.Interfaces;
using Project.Models.ViewModel;
namespace Project.Models.Repository;
public class DoctorRepository:IDoctor
{
    public bool checkDoctorExist(string email)
    {
        var db = new AppointmentSystemContext();
        return db.Doctors.Any(a => a.Email == email);
    }
    public bool validatePass(Doctor doc)
    {
        var db = new AppointmentSystemContext();
        return db.Doctors.Any(a => a.Email == doc.Email && a.Password == doc.Password);
    }
    public bool addDoctor(Doctor doc)
    {
        var db = new AppointmentSystemContext();
        if (checkDoctorExist(doc.Email))
            return false;
        else
        {

            db.Doctors.Add(doc);
            db.SaveChanges();
            return true;
        }
    }
    public Doctor getDoc(string Email)
    {
        var db = new AppointmentSystemContext();
        Doctor obj = db.Doctors.First(a => a.Email == Email);
        return obj;
    }
    public Doctor getDoc(int Id)
    {
        var db = new AppointmentSystemContext();
        Doctor obj = db.Doctors.First(a => a.Id == Id);
        return obj;
    }
    public DoctorSchedule getDocScheduleById(int Id)
    {
        var db = new AppointmentSystemContext();
        DoctorSchedule obj = db.DoctorSchedules.First(a => a.DoctorId == Id);
        return obj;
    }
    public DoctorSchedule getDocSchedule(int Id)
    {
        var db = new AppointmentSystemContext();
        DoctorSchedule obj = db.DoctorSchedules.First(a => a.DoctorId == Id);
        return obj;
    }
    public List<DocInfo> getDoctors()
    {
        var db = new AppointmentSystemContext();
        List<Doctor> list = db.Doctors.ToList();
        List<DocInfo> infoList = new List<DocInfo>();  
        foreach(Doctor obj in list)
        {
            DoctorSchedule docsch = new DoctorSchedule();
            DocInfo info = new DocInfo();
            docsch = getDocSchedule(obj.Id);
            info.AppDay = docsch.DoctorScheduleDay;
            info.AppDate = docsch.DoctorScheduleDate;
            info.AvailTime = docsch.DoctorScheduleStartTime +" - "+ docsch.DoctorScheduleEndTime;
            info.Name = obj.Name;
            info.Education = obj.Qualification;
            info.Speciality = obj.ExpertIn;
            infoList.Add(info);

        }
        return infoList;
    }
}
