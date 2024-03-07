﻿using IT_Roadmap.Core.Data;
using IT_Roadmap.Core.DTO;
using IT_Roadmap.Core.Repository;
using IT_Roadmap.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public int GetUserCount()
        {
            return _userRepository.GetUserCount();
        }


        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public List<AllUsersEmails> GetAllUsersEmail()
        {
            return _userRepository.GetAllUsersEmail();
        }

        public User GetUserById(decimal id)
        {
            return _userRepository.GetUserById(id);
        }

        public void CreateUser(User userData)
        {
            _userRepository.CreateUser(userData);
        }

        public void UpdateUser(User userData)
        {
            _userRepository.UpdateUser(userData);
        }

        public void DeleteUser(decimal id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}
