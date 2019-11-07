using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_Accounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId{get;set;}
        public decimal? Amount{get;set;}
        public int? UserId{get;set;}
        [NotMapped]
        public User UserInfo{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
    }
}