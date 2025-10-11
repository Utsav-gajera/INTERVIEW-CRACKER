using System;
using System.ComponentModel.DataAnnotations;

namespace InterviewCracker.Models
{
    public class CollegeCompany
    {
        public int Id { get; set; }
        
        [Required]
        public int CollegeId { get; set; }
        
        [Required]
        public int CompanyId { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public bool IsActive { get; set; } = true;
        
        // Navigation properties
        public College College { get; set; }
        public Company Company { get; set; }
    }
}