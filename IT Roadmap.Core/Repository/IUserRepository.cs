using IT_Roadmap.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Core.Repository
{
    public interface IUserRepository
    {
        public int GetUserCount();
        List<User> GetAllUsers();

        //List<AllUsersEmails> GetAllUsersEmail();
        User GetUserById(decimal id);
        void CreateUser(User userData);
        void UpdateUser(User userData);
        void DeleteUser(decimal id);
    }
}
