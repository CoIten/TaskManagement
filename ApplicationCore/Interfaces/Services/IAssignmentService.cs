using ApplicationCore.Models.Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Services
{
    public interface IAssignmentService
    {
        public Task<Assignment> GetAssignmentByIdAsync(int AssignmentId);
        public Task<List<Assignment>> GetAssignmentsAsync();
        public Task<Assignment> CreateAssignment(Assignment Assignment);
        public Task<Assignment> UpdateAssignment(Assignment AssignmentUpdate);
        public Task DeleteAssignment(int AssignmentId);
    }
}
