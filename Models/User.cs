using System;
using System.ComponentModel.DataAnnotations;

namespace InterviewCracker.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string Role { get; set; } // Student, Contributor, Admin
        
        public string Organization { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Bio { get; set; }
        
        public string LinkedInProfile { get; set; }
        
        public string GitHubProfile { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public bool IsActive { get; set; } = true;
    }
}
