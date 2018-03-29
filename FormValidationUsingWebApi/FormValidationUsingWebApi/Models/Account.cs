using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidationUsingWebApi.Models
{
    public class Account
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string uname { get; set; }

        [Required]
        [RegularExpression("((?=.*\\d)(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        public string pwd{ get; set; }

        [Range(18,50)]
        public int age{ get; set; }

        [Required]
        [EmailAddress]
        public string email{ get; set; }

        [Url]
        public string site { get; set; }

    }
}