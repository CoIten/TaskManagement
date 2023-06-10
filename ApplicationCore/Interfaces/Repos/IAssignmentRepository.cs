using ApplicationCore.Models.Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Repos
{
    public interface IAssignmentRepository
    {
        public Task<Assignment> GetAssignmentById(int AssignmentId);
        public Task<List<Assignment>> GetAssignmentsAsync();
        public Task<Assignment> CreateAssignment(Assignment Assignment);
        public Task UpdateAssignment(Assignment Assignment);
        public Task DeleteAssignment(Assignment Assignment);
    }
}
