using ApplicationCore.Models.Assignment;
using ApplicationCore.Models.UserAssignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Services
{
    public interface IUserAssignmentService
    {
        public Task<UserAssignment> AssignUserToAssignment(int userId, int assignmentId);
        public Task RemoveAssignmentFromUser(int userId, int assignmentId);
        public Task DeleteUserAssignment(int userId, int assignmentId);
    }
}
