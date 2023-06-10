using ApplicationCore.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> GetUserById(int userId);
        public Task<List<User>> GetUsersAsync();
        public Task<User> CreateUser(User User);
        public Task UpdateUser(User User);
        public Task DeleteUser(User User);
    }
}
