using ApplicationCore.Models.Assignments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.UserAssignments
{
    public class UserAssignment
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int AssignmentId { get; set; }

        [Required]
        [EnumDataType(typeof(UserAssignmentStatus))]
        [Column(TypeName = "nvarchar(100)")]
        public string Status { get; set; }
        
        [Required]
        public int AssignerId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime AssignmentDate { get; set; }

        public int? RemoverId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? RemoveDate { get; set; }
    }
}
