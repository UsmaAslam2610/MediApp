using Project.Models.ViewModel;
namespace Project.Models.Interfaces
{
    public interface IDoctor
    {
        bool checkDoctorExist(string email);
        bool validatePass(Doctor doc);
        bool addDoctor(Doctor doc);
        Doctor getDoc(string Email);
        DoctorSchedule getDocScheduleById(int Id);
        List<DocInfo> getDoctors();
    }
}
