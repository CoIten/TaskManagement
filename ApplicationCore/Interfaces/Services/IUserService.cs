using ApplicationCore.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Services
{
    public interface IUserService
    {
        public Task<User> GetUserByIdAsync(int userId);
        public Task<List<User>> GetUsersAsync();
        public Task<User> CreateUser(UserPost user);
        public Task<User> UpdateUser(UserUpdate userUpdate);
        public Task DeleteUser(int userId);
    }
}
