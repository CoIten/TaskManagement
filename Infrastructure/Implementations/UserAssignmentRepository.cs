using ApplicationCore.Interfaces.Repos;
using ApplicationCore.Models.UserAssignments;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementations
{
    public class UserAssignmentRepository : IUserAssignmentRepository
    {
        private readonly DataContext _dbContext;

        public UserAssignmentRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserAssignment> AssignUserToAssignmentAsync(UserAssignment UserAssignment)
        {
            await _dbContext.UserAssignments.AddAsync(UserAssignment);
            await _dbContext.SaveChangesAsync();
            return UserAssignment;
        }

        public async Task<UserAssignment> GetUserAssignmentAsync(int userId, int assignmentId)
        {
            return await _dbContext.UserAssignments
                .FirstOrDefaultAsync(UserAssignment => UserAssignment.UserId == userId && UserAssignment.AssignmentId == assignmentId);
        }

        public async Task RemoveUserFromAssignmentAsync(UserAssignment UserAssignment)
        {
            _dbContext.UserAssignments.Update(UserAssignment);
            await _dbContext.SaveChangesAsync();
        }
    }
}
