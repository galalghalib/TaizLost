using System.Linq;
using TaizlostSmart.Data;
using TaizlostSmart.Models;
using BCrypt.Net;

namespace TaizlostSmart.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public bool EmailExists(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public Users Register(Users user, string password)
        {
            if (EmailExists(user.Email))
                return null;

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public Users Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
                return null;

            bool valid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
            return valid ? user : null;
        }
        public int GetUsersCount()
        {
            return _context.Users.Count();
        }


    }
}
