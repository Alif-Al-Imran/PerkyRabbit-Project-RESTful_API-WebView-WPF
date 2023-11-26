using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class User
    {
        [Key]
        public string uname { get; set; }
        [Required]
        public string password { get; set; }

    }
}