using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Transcript
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TranscriptID { get; set; }

        [Required]
        public int StudentID { get; set; }

        [ForeignKey(nameof(StudentID))]
        public virtual Student Student { get; set; }

        [Required]
        public int CourseID { get; set; }

        [ForeignKey(nameof(CourseID))]
        public virtual Course Course { get; set; }

        [StringLength(2)]
        public string? Grade { get; set; }

        [Required, StringLength(20)]
        public string Semester { get; set; }
    }
}
