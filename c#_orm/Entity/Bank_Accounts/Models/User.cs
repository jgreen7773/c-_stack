using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_Accounts.Models
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
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password{get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [Compare("Password")]
        public string ConfirmPassword{get;set;}
        public List<Transaction> UsersTransactions{get;set;}
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