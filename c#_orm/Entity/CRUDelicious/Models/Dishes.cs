using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious
{
    public class Dishes
    {
        [Key]
        [Required]
        public int DishId{get;set;}
        [Required]
        public string Name{get;set;}
        [Required]
        public string Chef{get;set;}
        [Required]
        [Range(1,5)]
        public int Tastiness{get;set;}
        [Required]
        [Range(1,99999)]
        public int Calories{get;set;}
        [Required]
        public string Description{get;set;}
        [Required]
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        [Required]
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}