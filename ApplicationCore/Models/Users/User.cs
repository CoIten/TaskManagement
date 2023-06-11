using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Users
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression("^[^0-9]*$")]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression("^[^0-9]*$")]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!])(?=.*[a-zA-Z]).{8,}$")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string Password { get; set; }

        public string PasswordSalt { get; set; }
        public string HashedPassword { get; set; }

    }
}
