using System;
using System.ComponentModel.DataAnnotations;

namespace InterviewCracker.Models
{
    public class CodingQuestion
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Problem { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public string Solution { get; set; }
        
        public string SampleInput { get; set; }
        
        public string SampleOutput { get; set; }
        
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