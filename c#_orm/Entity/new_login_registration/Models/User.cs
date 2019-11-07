using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_login_registration.Models
{
    public class User
    {
        [Key]
        public int UserId{get;set;}



        [Required]
        [EmailAddress]
        public string Email{get;set;}



        [Required]
        public string FirstName{get;set;}



        [Required]
        public string LastName{get;set;}



        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password{get;set;}



        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;



        [NotMapped]
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword{get;set;}
    }
}