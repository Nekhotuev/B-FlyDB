using System.Collections.Generic;
using Core.Model;

namespace Service
{
    public interface IUserService
    {
        User GetUser(int id);
        IEnumerable<User> GetUsers();

        void CreateUser();
        void UpdateUser();
        void DeleteUser();
    }

    public class UserService
    {
    }
}
