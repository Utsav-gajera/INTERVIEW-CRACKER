using System;
using System.ComponentModel.DataAnnotations;

namespace InterviewCracker.Models
{
    public class MCQ
    {
        public int Id { get; set; }
        
        [Required]
        public string Question { get; set; }
        
        [Required]
        public string OptionA { get; set; }
        
        [Required]
        public string OptionB { get; set; }
        
        [Required]
        public string OptionC { get; set; }
        
        [Required]
        public string OptionD { get; set; }
        
        [Required]
        public string CorrectAnswer { get; set; } // A, B, C, or D
        
        public string Explanation { get; set; }
        
        public string Topic { get; set; }
        
        public string Tags { get; set; }
        
        public int CompanyId { get; set; }
        
        public int CollegeId { get; set; }
        
        public int Year { get; set; }
        
        public string Difficulty { get; set; } // Easy, Medium, Hard
        
        public int ContributorId { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public bool IsApproved { get; set; } = false;
        
        public bool IsActive { get; set; } = true;
    }
}