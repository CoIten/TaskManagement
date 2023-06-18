using ApplicationCore.Models.UserAssignments;
using ApplicationCore.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Repos
{
    public interface IUserAssignmentRepository
    {
        public Task<UserAssignment> AssignUserToAssignmentAsync(UserAssignment UserAssignment);
        public Task<UserAssignment> GetUserAssignmentAsync(int userId, int assignmentId);
        public Task RemoveUserFromAssignmentAsync(UserAssignment UserAssignment);
    }
}
