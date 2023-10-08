using System.Linq;

namespace Project.Models.Repository;

using Project.Models;
using Project.Models.Interfaces;

public class AdminRepository:IAdmin
{
    public  int AdminId { get; set; }
    public bool checkAdminExist(string email)
    {
        var db = new AppointmentSystemContext();
        return db.Admins.Any(a => a.Email == email);
    }
    public bool validatePass(Admin ad)
    {
        var db = new AppointmentSystemContext();
        return db.Admins.Any(a => a.Email == ad.Email && a.Password == ad.Password);
    }
    public bool addAdmin(Admin ad)
    {
        var db = new AppointmentSystemContext();
        if (checkAdminExist(ad.Email))
            return false;
        else
        {
            db.Admins.Add(ad);
            db.SaveChanges();
            return true;
        }
    }
    public Admin getAdmin(string Email)
    {
        var db = new AppointmentSystemContext();
        Admin obj = db.Admins.First(a => a.Email == Email);
        return obj;
    }

}
