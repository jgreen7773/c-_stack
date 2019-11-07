using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wedding_Planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId{get;set;}
        [Required(ErrorMessage="You need to have two people involved to process a wedding.")]
        // [RegularExpression("^[a-zA-Z ]", ErrorMessage="You may only use letters and spaces.")]
        public string WedderOne{get;set;}
        [Required(ErrorMessage="You need to have two people involved to process a wedding.")]
        public string WedderTwo{get;set;}
        [FutureDate]
        [Required]
        public DateTime WeddingDate{get;set;}
        [Required(ErrorMessage="An address is required to post a wedding.")]
        public string WeddingAddress{get;set;}
        public User Creator{get;set;}
        public int UserId{get;set;}
        public List<Association> GuestsAttending{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }

    public class FutureDateAttribute : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
        // You first may want to unbox "value" here and cast to a DateTime variable!
            if ((DateTime) value < DateTime.Now) {
                return new ValidationResult ("The date entered is not a future date.");
            }
            return ValidationResult.Success;
        }
    }
}