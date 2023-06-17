using ApplicationCore.Interfaces.Repos;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models.Assignment;
using ApplicationCore.Models.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.Implementations
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public AssignmentService(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public async Task<Assignment> GetAssignmentByIdAsync(int AssignmentId)
        {
            return await _assignmentRepository.GetAssignmentById(AssignmentId);
        }

        public async Task<List<Assignment>> GetAssignmentsAsync()
        {
            return await _assignmentRepository.GetAssignmentsAsync();
        }

        public async Task<Assignment> CreateAssignment(Assignment Assignment)
        {
            var createdAssignment = await _assignmentRepository.CreateAssignment(Assignment);
            return createdAssignment;
        }

        public async Task<Assignment> UpdateAssignment(Assignment Assignment)
        {
            var existentAssignment = await _assignmentRepository.GetAssignmentById(Assignment.Id);
            if (existentAssignment == null)
            {
                throw new Exception("Assignment Not Found!");
            }

            existentAssignment.Title = Assignment.Title;
            existentAssignment.Description = Assignment.Description;
            existentAssignment.Status = Assignment.Status;
            existentAssignment.Priority = Assignment.Priority;
            existentAssignment.DueDate = Assignment.DueDate;
            existentAssignment.AssignedToUser = Assignment.AssignedToUser;

            await _assignmentRepository.UpdateAssignment(existentAssignment);
            return existentAssignment;
        }

        public async Task DeleteAssignment(int assignmentId)
        {
            var existentAssignment = await _assignmentRepository.GetAssignmentById(assignmentId);
            if (existentAssignment == null)
            {
                throw new Exception("User Not Found!");
            }

            await _assignmentRepository.DeleteAssignment(existentAssignment);
        }
    }
}
