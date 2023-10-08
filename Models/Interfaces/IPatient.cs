using Project.Models.ViewModel;
namespace Project.Models.Interfaces
{
    public interface IPatient
    {
        bool checkPatientExist(string email);
        bool validatePass(string Email, string Password);
        bool addPatient(Patient pa);
        List<Appointment> getPatientAppo(string email);
        Patient getPat(string Email);
        bool DelAppointments(int Id);
        List<UserAppointments> GetUserAppointments(string email);
    }
}
