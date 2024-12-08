using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Advisor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdvisorId { get; set; }
        [StringLength(100)]
        [Required]
        public string FullName { get; set; }
        [StringLength(50)]
        [Required]
        public string Title { get; set; }
        [StringLength(100)]
        [Required]
        public string Department { get; set; }
        [StringLength(100)]
        [Required]
        public string Email { get; set; }
    }
}
