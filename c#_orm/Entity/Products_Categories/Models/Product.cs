using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products_Categories
{
    public class Product
    {
        [Key]
        public int ProductId{get;set;}
        public string ProductName{get;set;}
        public string Description{get;set;}
        public decimal Price{get;set;}
        public List<Association> CategoryOfProduct{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}