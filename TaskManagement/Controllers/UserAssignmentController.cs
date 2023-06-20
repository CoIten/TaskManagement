using ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace TaskManagement.Controllers
{
    public class UserAssignmentController : Controller
    {
        private readonly IUserAssignmentService _userAssignmentService;

        public UserAssignmentController(IUserAssignmentService userAssignmentService)
        {
            _userAssignmentService = userAssignmentService;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AssignUserToAssignment(int userId, int assignmentId, int assignerId)
        {
            var createdUserAssignment = await _userAssignmentService.AssignUserToAssignment(userId, assignmentId, assignerId);
            return View(createdUserAssignment);
        }

        public async Task<IActionResult> RemoveUserFromAssignment(int userId, int assignmentId, int removerId)
        {
            await _userAssignmentService.RemoveUserFromAssignment(userId, assignmentId, removerId);
            return RedirectToAction(nameof(Index), "Assignment");
        }
    }
}
