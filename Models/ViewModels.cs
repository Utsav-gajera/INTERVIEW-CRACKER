using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InterviewCracker.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }

    public class CollegeViewModel
    {
        public List<College> Colleges { get; set; }
        public string SearchTerm { get; set; }
        public string FilterLocation { get; set; }
    }

    public class CompanyViewModel
    {
        public List<Company> Companies { get; set; }
        public College College { get; set; }
        public string SearchTerm { get; set; }
    }

    public class QuestionsViewModel
    {
        public List<MCQ> MCQs { get; set; }
        public List<CodingQuestion> CodingQuestions { get; set; }
        public College College { get; set; }
        public Company Company { get; set; }
        public int? FilterYear { get; set; }
        public string FilterDifficulty { get; set; }
        public string SearchTerm { get; set; }
    }

    public class ProfileViewModel
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        
        [Display(Name = "Role")]
        public string Role { get; set; }
        
        [Display(Name = "College/Organization")]
        public string Organization { get; set; }
        
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }
        
        [Display(Name = "Bio")]
        [StringLength(500, ErrorMessage = "Bio cannot exceed 500 characters")]
        public string Bio { get; set; }
        
        [Display(Name = "LinkedIn Profile")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string LinkedInProfile { get; set; }
        
        [Display(Name = "GitHub Profile")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string GitHubProfile { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }
    }

    public class AssignCompanyToCollegeViewModel
    {
        [Required]
        public int CollegeId { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public List<SelectListItem> CollegeList { get; set; }
        public List<SelectListItem> CompanyList { get; set; }
    }
}
