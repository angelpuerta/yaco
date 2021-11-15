using authentication.Models;

namespace authentication.Services
{
    public interface IUserService
    {
        public string Authenticate(string userName, string password);
    }
}