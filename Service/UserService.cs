using System.Collections.Generic;
using Core.Model;
using Data.Infrastructure;
using Data.Repositories;

namespace Service
{
    public interface IUserService
    {
        User GetUser(int id);
        IEnumerable<User> GetUsers();

        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        void SaveUser();
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        #region IUserServiceMembers

        public User GetUser(int id)
        {
            return _userRepository.GetById(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public void CreateUser(User user)
        {
            _userRepository.Add(user);
            SaveUser();
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
            SaveUser();
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(_userRepository.GetById(id));
            SaveUser();
        }

        public void SaveUser()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
