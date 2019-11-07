using System.ComponentModel.DataAnnotations;
namespace Dojo_Survey.Models
{
    public class SurveyUser
    {
        [Required]
        [MinLength(2)]
        public string Name{get;set;}
        [Required]
        public string Location{get;set;}
        [Required]
        public string Language{get;set;}
        [MaxLength(20)]
        public string Comments{get;set;}
        
    }
}