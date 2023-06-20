using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models.Assignment;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        public async Task<IActionResult> Index()
        {
            var assignments = await _assignmentService.GetAssignmentsAsync();
            return View(assignments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                var createdAssignment = await _assignmentService.CreateAssignment(assignment);
                return RedirectToAction(nameof(Details), new { assignmentId = createdAssignment.Id });
            }

            return View(assignment);
        }

        public async Task<IActionResult> Details(int assignmentId)
        {
            var assignment = await _assignmentService.GetAssignmentByIdAsync(assignmentId);
            if (assignment == null)
                return NotFound();

            return View(assignment);
        }
    }
}
