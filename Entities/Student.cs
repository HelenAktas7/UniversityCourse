using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        public int? AdvisorID { get; set; }

        [ForeignKey(nameof(AdvisorID))]
        public virtual Advisor Advisor { get; set; }

        [Required]
        public DateTime EnrollmentDate { get; set; }
    }
}
