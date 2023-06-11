using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.UserAssignments
{
    public class UserAssignment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AssignmentId { get; set; }
        public string Status { get; set; }
    }
}
