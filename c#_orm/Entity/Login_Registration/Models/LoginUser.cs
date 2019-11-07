using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login_Registration.Models
{
    public class LoginUser
    {
        [Key]
        [Required]
        public int LoginUserId{get;set;}
        [Required]
        [EmailAddress]
        public string LoginEmail{get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}