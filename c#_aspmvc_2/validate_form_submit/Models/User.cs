
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace validate_form_submit.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "Your First Name:")]
        public string Fname{get;set;}
        [Required]
        [MinLength(4)]
        [Display(Name = "Your Last Name:")]
        public string Lname{get;set;}
        [Required]
        [Range(0,999)]
        [Display(Name = "Age:")]
        public int Age{get;set;}
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string Email{get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        // [Compare(CPassword, ErrorMessage = "Passwords must match!")]
        [Display(Name = "Password:")]
        public string Password{get;set;}
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password:")]
        public string CPassword{get;set;}
    }
}