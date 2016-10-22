using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Design_Lab_Week_2.Models
{
    public class User
    {
        [Key]
        public int m_id { get; set; }

        [Display (Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display (Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display (Name = "Email")]
        [Required]
        public string Email { get; set; }
    }
}