using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chefs_N_Dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId{get;set;}
        [Required]
        public string DishName{get;set;}
        [Required]
        [Range(0,99999)]
        public int Calories{get;set;}
        [Required]
        public int Tastiness{get;set;}
        [Required]
        public string Description{get;set;}



        public int ChefId{get;set;}
        [NotMapped]
        public Chef Chef{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}