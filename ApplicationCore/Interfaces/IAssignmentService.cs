using ApplicationCore.Models.Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IAssignmentService
    {
        public Task<Assignment> GetAssignmentByIdAsync(int AssignmentId);
        public Task<List<Assignment>> GetAssignmentsAsync();
        public Task<Assignment> CreateAssignment(AssignmentPost Assignment);
        public Task<Assignment> UpdateAssignment(AssignmentUpdate AssignmentUpdate);
        public Task DeleteAssignment(int AssignmentId);
    }
}
