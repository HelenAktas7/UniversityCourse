using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required, StringLength(100)]
        public string Username { get; set; }

        [Required, StringLength(255)]
        public string PasswordHash { get; set; }

        [Required, StringLength(50)]
        public string Role { get; set; }

        public int? RelatedID { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }
    }
}
