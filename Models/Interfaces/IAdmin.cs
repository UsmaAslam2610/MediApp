namespace Project.Models.Interfaces
{
    public interface IAdmin
    {
        bool checkAdminExist(string email);
        bool validatePass(Admin ad);
        bool addAdmin(Admin ad);
        Admin getAdmin(string Email);
    }
}
