using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_login_registration.Models
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
        [MinLength(8)]
        public string LoginPassword{get;set;}
    }
}