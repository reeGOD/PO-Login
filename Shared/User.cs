using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Login.Shared.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(255, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        public int Role { get; set; }
    }
}
