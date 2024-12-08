using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudentCourseSelection
    {
        
        
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int SelectionID { get; set; }
            [Required]
            public int StudentID { get; set; }
            [Required]
            public int CourseID { get; set; }
            [Required]
            public DateTime SelectionDate { get; set; }
            public bool IsApproved { get; set; }
        
    }
}
