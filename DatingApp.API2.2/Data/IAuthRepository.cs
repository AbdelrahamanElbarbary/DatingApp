using System.Threading.Tasks;
using DatingApp.API2._2.Models;

namespace DatingApp.API2._2.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string Username , string password);
        Task<bool> UserExists(string Username);
    }
}