using ApplicationCore.Interfaces.Repos;
using ApplicationCore.Models.Users;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dbContext;

        public UserRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserById(int userId)
        {
            return await _dbContext.Users.FindAsync(userId);
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
        public async Task<User> CreateUser(User User)
        {
            await _dbContext.Users.AddAsync(User);
            await _dbContext.SaveChangesAsync();
            return User;
        }
        public async Task UpdateUser(User User)
        {
            _dbContext.Users.Update(User);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteUser(User User)
        {
            _dbContext.Users.Remove(User);
            await _dbContext.SaveChangesAsync();
        }
    }
}
