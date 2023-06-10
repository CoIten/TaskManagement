using ApplicationCore.Models.Assignment;
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
        private readonly IAssignmentRepository _AssignmentRepository;

        public AssignmentService(IAssignmentRepository AssignmentRepository)
        {
            _AssignmentRepository = AssignmentRepository;
        }

        public async Task<Assignment> GetAssignmentById(int assignmentId)
        {
            return await _AssignmentRepository.GetAssignmentById(assignmentId);
        }

        public void CreateAssignment(Assignment Assignment)
        {
        }

        public void UpdateAssignment(Assignment Assignment)
        {

        }

        public void DeleteAssignment(int assignmentId)
        {

        }
    }
}
