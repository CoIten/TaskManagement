using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Models.Users;
using ApplicationCore.Models.Assignments;

namespace ApplicationCore.Models.Assignment
{
    public class Assignment
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }

        [Required]
        [StringLength(4000)]
        [Column(TypeName = "nvarchar(4000)")]
        public string Description { get; set; }

        [Required]
        [EnumDataType(typeof(AssignmentStatus))]
        [Column(TypeName = "nvarchar(20)")]
        public string Status { get; set; }

        [Required]
        [EnumDataType(typeof(AssignmentPriority))]
        [Column(TypeName = "nvarchar(20)")]
        public string Priority { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DueDate { get; set; }

        [Required]
        public User AssignedToUser { get; set; }
    }
}
