using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterviewCracker.Models
{
    public class Company
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string Website { get; set; }
        
        public string LogoUrl { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public bool IsActive { get; set; } = true;
        
        // Navigation properties for many-to-many relationship
        public virtual ICollection<CollegeCompany> CollegeCompanies { get; set; } = new List<CollegeCompany>();
    }
}