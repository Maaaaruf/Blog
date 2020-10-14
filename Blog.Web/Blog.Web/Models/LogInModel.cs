using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Web.Models
{
    public class LogInModel
    {
        [Display(Name = "User name")]
        [Required]
        public string UserName { get; set; }

        //[DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}