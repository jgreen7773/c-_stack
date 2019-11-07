using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chefs_N_Dishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId{get;set;}
        [Required]
        public string FirstName{get;set;}
        [Required]
        public string LastName{get;set;}
        [FutureDate]
        [Required]
        public DateTime BirthDate{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;



        public List<Dish> ListDishes{get;set;}






        public static bool IsDateInPast(Chef obj)
        {
            string strDate = obj.ToString();
            try
            {
                DateTime dt = DateTime.Parse(strDate);
                if((dt.Month>System.DateTime.Now.Month) || (dt.Day<1&&dt.Day>31) || dt.Year>System.DateTime.Now.Year)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class FutureDateAttribute : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
        // You first may want to unbox "value" here and cast to a DateTime variable!
            if ((DateTime) value > DateTime.Now) {
                return new ValidationResult ("The date entered is not a past date.");
            }
            return ValidationResult.Success;
        }
    }
}