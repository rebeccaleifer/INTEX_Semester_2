using System;
using System.ComponentModel.DataAnnotations;

namespace Intex_Semester_2.Models
{
    public class Identity
    {
        [Key]
        [Required]
        public int user_id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        public string role { get; set; }
        public bool mfa { get; set; }
    }
}
