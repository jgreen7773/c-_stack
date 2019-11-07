using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products_Categories
{
    public class Category
    {
        [Key]
        public int CategoryId{get;set;}
        public string CategoryName{get;set;}
        public List<Association> ProductInCategory{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}