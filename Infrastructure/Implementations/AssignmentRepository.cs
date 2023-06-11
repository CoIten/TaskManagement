using ApplicationCore.Interfaces.Repos;
using ApplicationCore.Models.Assignment;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementations
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly DataContext _dbContext;

        public AssignmentRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Assignment> GetAssignmentById(int AssignmentId)
        {
            return await _dbContext.Assignments.FindAsync(AssignmentId);
        }
        public async Task<List<Assignment>> GetAssignmentsAsync()
        {
            return await _dbContext.Assignments.ToListAsync();
        }
        public async Task<Assignment> CreateAssignment(Assignment Assignment)
        {
            await _dbContext.Assignments.AddAsync(Assignment);
            await _dbContext.SaveChangesAsync();
            return Assignment;
        }
        public async Task UpdateAssignment(Assignment Assignment)
        {
            _dbContext.Assignments.Update(Assignment);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAssignment(Assignment Assignment)
        {
            _dbContext.Assignments.Remove(Assignment);
            await _dbContext.SaveChangesAsync();
        }
    }
}
