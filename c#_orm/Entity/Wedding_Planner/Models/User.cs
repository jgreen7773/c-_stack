using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wedding_Planner.Models
{
    public class User
    {
        [Key]
        public int UserId{get;set;}
        [Required]
        public string FirstName{get;set;}
        [Required]
        public string LastName{get;set;}
        [Required]
        [EmailAddress]
        public string Email{get;set;}
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password{get;set;}
        [NotMapped]
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword{get;set;}
        public List<Association> WeddingsAttending{get;set;}
        [NotMapped]
        public List<Wedding> WeddingsCreated{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }

    public class LoginUser
    {
        [NotMapped]
        public string LoginEmail{get;set;}
        [NotMapped]
        public string LoginPassword{get;set;}
    }
}
// Regex letter = new Regex("^[a-zA-Z]*$");
        // if(letter.IsMatch(Name))
        // {
            
        // }
// Regex numletter = new Regex("^[a-zA-Z0-9]*$");

