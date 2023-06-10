using ApplicationCore.Interfaces.Repos;
using ApplicationCore.Interfaces.Services;
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

        public async Task<Assignment> GetAssignmentByIdAsync(int AssignmentId)
        {
            return await _AssignmentRepository.GetAssignmentById(AssignmentId);
        }

        public void CreateAssignment(Assignment Assignment)
        {

        }

        public void UpdateAssignment(Assignment Assignment)
        {

        }

        public void DeleteAssignment(int AssignmentId)
        {

        }
    }
}
