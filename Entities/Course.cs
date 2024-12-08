using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [StringLength(20)]
        [Required]
        public string CourseCode { get; set; }
        [StringLength(100)]
        [Required]
        public string CourseName { get; set; }
        [Required]
        public bool IsMandatory { get; set; }
        [Required]
        public int Credit { get; set; }
        [StringLength(100)]
        [Required]
        public string Department { get; set; }
    }
}
