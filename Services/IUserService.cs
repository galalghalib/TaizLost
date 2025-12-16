using TaizlostSmart.Models;

namespace TaizlostSmart.Services
{
    public interface IUserService
    {
        Users Register(Users user, string password);
        Users Login(string email, string password);
        bool EmailExists(string email);
        int GetUsersCount();

    }
}
