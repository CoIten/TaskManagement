using ApplicationCore.Interfaces.Repos;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models.UserAssignments;
using ApplicationCore.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.Implementations
{
    public class UserAssignmentService : IUserAssignmentService
    {
        private readonly IUserAssignmentRepository _userAssignmentRepository;

        public UserAssignmentService(IUserAssignmentRepository userAssignmentRepository)
        {
            _userAssignmentRepository = userAssignmentRepository;
        }

        [Authorize(Roles = "Admin")]
        public async Task<UserAssignment> AssignUserToAssignment(int userId, int assignmentId, int assignerId)
        {

            var createdUserAssignment = await _userAssignmentRepository.AssignUserToAssignmentAsync(new UserAssignment
            {
                UserId = userId,
                AssignmentId = assignmentId,
                Status = UserAssignmentStatus.Active.ToString(),
                AssignerId = assignerId,
                AssignmentDate = DateTime.Now
            });
            return createdUserAssignment;
        }

        public async Task RemoveUserFromAssignment(int userId, int assignmentId, int removerId)
        {
            var UserAssignment = await _userAssignmentRepository.GetUserAssignmentAsync(userId, assignmentId);
            if (UserAssignment == null)
                throw new Exception("User Assignment Not Found!");

            await _userAssignmentRepository.RemoveUserFromAssignmentAsync(new UserAssignment
            {
                Id = UserAssignment.Id,
                UserId = UserAssignment.UserId,
                AssignmentId = UserAssignment.AssignmentId,
                Status = UserAssignmentStatus.Inactive.ToString(),
                AssignerId = UserAssignment.AssignerId,
                AssignmentDate = UserAssignment.AssignmentDate,
                RemoverId = removerId,
                RemoveDate = DateTime.Now
            });
        }
    }
}
