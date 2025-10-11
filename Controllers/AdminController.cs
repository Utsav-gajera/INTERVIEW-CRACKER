using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InterviewCracker.Models;
using InterviewCracker.Services;

namespace InterviewCracker.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICollegeService _collegeService;
        private readonly ICompanyService _companyService;
        private readonly ICodingQuestionService _codingQuestionService;
        private readonly IMCQService _mcqService;

        public AdminController(
            IUserService userService,
            ICollegeService collegeService,
            ICompanyService companyService,
            ICodingQuestionService codingQuestionService,
            IMCQService mcqService)
        {
            _userService = userService;
            _collegeService = collegeService;
            _companyService = companyService;
            _codingQuestionService = codingQuestionService;
            _mcqService = mcqService;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + "InterviewCracker_Salt"));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public async Task<IActionResult> Dashboard()
        {
            var allUsers = await _userService.GetAllAsync();
            var allColleges = await _collegeService.GetAllAsync();
            var allCompanies = await _companyService.GetAllAsync();
            var allCodingQuestions = await _codingQuestionService.GetAllAsync();
            var allMCQs = await _mcqService.GetAllAsync();

            ViewBag.TotalColleges = allColleges.Count(c => c.IsActive);
            ViewBag.TotalUsers = allUsers.Count(u => u.IsActive);
            ViewBag.TotalContributors = allUsers.Count(u => u.Role == "Contributor" && u.IsActive);
            ViewBag.TotalStudents = allUsers.Count(u => u.Role == "Student" && u.IsActive);
            ViewBag.TotalQuestions = allCodingQuestions.Count(q => q.IsActive) + allMCQs.Count(q => q.IsActive);
            
            return View();
        }

        public async Task<IActionResult> ManageColleges()
        {
            var colleges = await _collegeService.GetActiveCollegesAsync();
            return View(colleges);
        }

        public IActionResult AddCollege()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCollege(College model, IFormFile imageFile)
        {
            if (ModelState.IsValid)
            {
                // Handle image upload
                if (imageFile != null && imageFile.Length > 0)
                {
                    try
                    {
                        // Validate file size (5MB max)
                        if (imageFile.Length > 5 * 1024 * 1024)
                        {
                            ModelState.AddModelError("ImageUrl", "Image file size must be less than 5MB.");
                            return View(model);
                        }

                        // Validate file type
                        var allowedTypes = new[] { "image/jpeg", "image/jpg", "image/png", "image/gif", "image/webp" };
                        if (!allowedTypes.Contains(imageFile.ContentType.ToLower()))
                        {
                            ModelState.AddModelError("ImageUrl", "Only image files (JPG, PNG, GIF, WebP) are allowed.");
                            return View(model);
                        }

                        // Generate unique filename
                        var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(imageFile.FileName);
                        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "colleges");
                        
                        // Create directory if it doesn't exist
                        if (!Directory.Exists(uploadsFolder))
                        {
                            Directory.CreateDirectory(uploadsFolder);
                        }
                        
                        var filePath = Path.Combine(uploadsFolder, fileName);
                        
                        // Save the file
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(fileStream);
                        }
                        
                        // Set the ImageUrl to the relative path
                        model.ImageUrl = $"/images/colleges/{fileName}";
                    }
                    catch (Exception)
                    {
                        ModelState.AddModelError("ImageUrl", "Error uploading image. Please try again.");
                        return View(model);
                    }
                }

                model.CreatedDate = DateTime.Now;
                model.IsActive = true;
                await _collegeService.AddAsync(model);
                
                TempData["Message"] = "College added successfully!";
                return RedirectToAction("ManageColleges");
            }
            
            return View(model);
        }

        public async Task<IActionResult> EditCollege(int id)
        {
            var college = await _collegeService.GetByIdAsync(id);
            if (college == null)
            {
                return NotFound();
            }
            
            return View(college);
        }

        [HttpPost]
        public async Task<IActionResult> EditCollege(College model, IFormFile imageFile)
        {
            if (ModelState.IsValid)
            {
                // Handle image upload if a new file is provided
                if (imageFile != null && imageFile.Length > 0)
                {
                    try
                    {
                        // Validate file size (5MB max)
                        if (imageFile.Length > 5 * 1024 * 1024)
                        {
                            ModelState.AddModelError("ImageUrl", "Image file size must be less than 5MB.");
                            return View(model);
                        }

                        // Validate file type
                        var allowedTypes = new[] { "image/jpeg", "image/jpg", "image/png", "image/gif", "image/webp" };
                        if (!allowedTypes.Contains(imageFile.ContentType.ToLower()))
                        {
                            ModelState.AddModelError("ImageUrl", "Only image files (JPG, PNG, GIF, WebP) are allowed.");
                            return View(model);
                        }

                        // Generate unique filename
                        var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(imageFile.FileName);
                        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "colleges");
                        
                        // Create directory if it doesn't exist
                        if (!Directory.Exists(uploadsFolder))
                        {
                            Directory.CreateDirectory(uploadsFolder);
                        }
                        
                        var filePath = Path.Combine(uploadsFolder, fileName);
                        
                        // Save the file
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(fileStream);
                        }
                        
                        // Delete old image file if it exists and is not a default image
                        if (!string.IsNullOrEmpty(model.ImageUrl) && model.ImageUrl.StartsWith("/images/colleges/"))
                        {
                            var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", model.ImageUrl.TrimStart('/'));
                            if (System.IO.File.Exists(oldFilePath))
                            {
                                System.IO.File.Delete(oldFilePath);
                            }
                        }
                        
                        // Set the ImageUrl to the new relative path
                        model.ImageUrl = $"/images/colleges/{fileName}";
                    }
                    catch (Exception)
                    {
                        ModelState.AddModelError("ImageUrl", "Error uploading image. Please try again.");
                        return View(model);
                    }
                }

                await _collegeService.UpdateAsync(model);
                TempData["Message"] = "College updated successfully!";
                return RedirectToAction("ManageColleges");
            }
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCollege(int id)
        {
            try
            {
                var college = await _collegeService.GetByIdAsync(id);
                if (college == null)
                {
                    TempData["ErrorMessage"] = "College not found.";
                    return RedirectToAction("ManageColleges");
                }
                
                // Soft delete - mark as inactive instead of hard delete
                college.IsActive = false;
                await _collegeService.UpdateAsync(college);
                
                TempData["Message"] = $"College '{college.Name}' has been deleted successfully!";
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the college. Please try again.";
            }
            
            return RedirectToAction("ManageColleges");
        }

        // Company Management Methods
        public async Task<IActionResult> ManageCompanies()
        {
            var companies = await _companyService.GetAllAsync();
            return View(companies);
        }

        public IActionResult AddCompany()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCompany(Company model, IFormFile logoFile)
        {
            if (ModelState.IsValid)
            {
                // Handle logo upload
                if (logoFile != null && logoFile.Length > 0)
                {
                    try
                    {
                        // Validate file size (5MB max)
                        if (logoFile.Length > 5 * 1024 * 1024)
                        {
                            ModelState.AddModelError("LogoUrl", "Logo file size must be less than 5MB.");
                            return View(model);
                        }

                        // Validate file type
                        var allowedTypes = new[] { "image/jpeg", "image/jpg", "image/png", "image/gif", "image/webp" };
                        if (!allowedTypes.Contains(logoFile.ContentType.ToLower()))
                        {
                            ModelState.AddModelError("LogoUrl", "Only image files (JPG, PNG, GIF, WebP) are allowed.");
                            return View(model);
                        }

                        // Generate unique filename
                        var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(logoFile.FileName);
                        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "companies");
                        
                        // Create directory if it doesn't exist
                        if (!Directory.Exists(uploadsFolder))
                        {
                            Directory.CreateDirectory(uploadsFolder);
                        }
                        
                        var filePath = Path.Combine(uploadsFolder, fileName);
                        
                        // Save the file
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await logoFile.CopyToAsync(fileStream);
                        }
                        
                        // Set the LogoUrl to the relative path
                        model.LogoUrl = $"/images/companies/{fileName}";
                    }
                    catch (Exception)
                    {
                        ModelState.AddModelError("LogoUrl", "Error uploading logo. Please try again.");
                        return View(model);
                    }
                }

                model.CreatedDate = DateTime.Now;
                model.IsActive = true;
                await _companyService.AddAsync(model);
                
                TempData["Message"] = "Company added successfully!";
                return RedirectToAction("ManageCompanies");
            }
            
            return View(model);
        }

        public async Task<IActionResult> EditCompany(int id)
        {
            var company = await _companyService.GetByIdAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            
            return View(company);
        }

        [HttpPost]
        public async Task<IActionResult> EditCompany(Company model, IFormFile logoFile)
        {
            if (ModelState.IsValid)
            {
                // Handle logo upload if a new file is provided
                if (logoFile != null && logoFile.Length > 0)
                {
                    try
                    {
                        // Validate file size (5MB max)
                        if (logoFile.Length > 5 * 1024 * 1024)
                        {
                            ModelState.AddModelError("LogoUrl", "Logo file size must be less than 5MB.");
                            return View(model);
                        }

                        // Validate file type
                        var allowedTypes = new[] { "image/jpeg", "image/jpg", "image/png", "image/gif", "image/webp" };
                        if (!allowedTypes.Contains(logoFile.ContentType.ToLower()))
                        {
                            ModelState.AddModelError("LogoUrl", "Only image files (JPG, PNG, GIF, WebP) are allowed.");
                            return View(model);
                        }

                        // Generate unique filename
                        var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(logoFile.FileName);
                        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "companies");
                        
                        // Create directory if it doesn't exist
                        if (!Directory.Exists(uploadsFolder))
                        {
                            Directory.CreateDirectory(uploadsFolder);
                        }
                        
                        var filePath = Path.Combine(uploadsFolder, fileName);
                        
                        // Save the file
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await logoFile.CopyToAsync(fileStream);
                        }
                        
                        // Delete old logo file if it exists and is not a default logo
                        if (!string.IsNullOrEmpty(model.LogoUrl) && model.LogoUrl.StartsWith("/images/companies/"))
                        {
                            var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", model.LogoUrl.TrimStart('/'));
                            if (System.IO.File.Exists(oldFilePath))
                            {
                                System.IO.File.Delete(oldFilePath);
                            }
                        }
                        
                        // Set the LogoUrl to the new relative path
                        model.LogoUrl = $"/images/companies/{fileName}";
                    }
                    catch (Exception)
                    {
                        ModelState.AddModelError("LogoUrl", "Error uploading logo. Please try again.");
                        return View(model);
                    }
                }

                await _companyService.UpdateAsync(model);
                TempData["Message"] = "Company updated successfully!";
                return RedirectToAction("ManageCompanies");
            }
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            try
            {
                var company = await _companyService.GetByIdAsync(id);
                if (company == null)
                {
                    TempData["ErrorMessage"] = "Company not found.";
                    return RedirectToAction("ManageCompanies");
                }

                // Soft delete - mark as inactive instead of hard delete
                company.IsActive = false;
                await _companyService.UpdateAsync(company);
                TempData["Message"] = $"Company '{company.Name}' has been deleted successfully!";
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the company. Please try again.";
            }
            
            return RedirectToAction("ManageCompanies");
        }

        public async Task<IActionResult> ManageUsers()
        {
            var users = await _userService.GetAllAsync();
            return View(users.Where(u => u.IsActive).ToList());
        }

        public IActionResult AddContributor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddContributor(User model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userService.GetByEmailAsync(model.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError("", "Email already exists.");
                    return View(model);
                }

                // Hash the password before saving
                model.Password = HashPassword(model.Password);
                model.Role = "Contributor";
                model.CreatedDate = DateTime.Now;
                model.IsActive = true;
                await _userService.AddAsync(model);
                
                TempData["Message"] = "Contributor added successfully!";
                return RedirectToAction("ManageUsers");
            }
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var user = await _userService.GetByIdAsync(id);
                if (user == null)
                {
                    TempData["Error"] = "User not found.";
                    return RedirectToAction("ManageUsers");
                }

                if (user.Role == "Admin")
                {
                    TempData["Error"] = "Cannot delete admin users.";
                    return RedirectToAction("ManageUsers");
                }

                if (!user.IsActive)
                {
                    TempData["Error"] = "User is already deleted.";
                    return RedirectToAction("ManageUsers");
                }

                // Soft delete - mark as inactive
                user.IsActive = false;
                await _userService.UpdateAsync(user);
                
                TempData["Message"] = $"User '{user.Name}' has been successfully deleted.";
            }
            catch (Exception)
            {
                TempData["Error"] = "An error occurred while deleting the user. Please try again.";
            }
            
            return RedirectToAction("ManageUsers");
        }

        [HttpPost]
        public async Task<IActionResult> AutoApproveAllCodingQuestions()
        {
            try
            {
                var allQuestions = await _codingQuestionService.GetAllAsync();
                var pendingQuestions = allQuestions.Where(q => !q.IsApproved).ToList();
                
                foreach (var question in pendingQuestions)
                {
                    question.IsApproved = true;
                    await _codingQuestionService.UpdateAsync(question);
                }
                
                TempData["Message"] = $"Successfully auto-approved {pendingQuestions.Count} coding questions.";
            }
            catch (Exception)
            {
                TempData["Error"] = "An error occurred while auto-approving coding questions.";
            }
            
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        public async Task<IActionResult> AssignCompanyToCollege()
        {
            var colleges = await _collegeService.GetAllAsync();
            var companies = await _companyService.GetAllAsync();
            var model = new AssignCompanyToCollegeViewModel
            {
                CollegeList = colleges.Where(c => c.IsActive)
                    .Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Value = c.Id.ToString(), Text = c.Name }).ToList(),
                CompanyList = companies.Where(c => c.IsActive)
                    .Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Value = c.Id.ToString(), Text = c.Name }).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AssignCompanyToCollege(AssignCompanyToCollegeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please select both college and company.";
                return RedirectToAction("AssignCompanyToCollege");
            }
            var success = await _collegeService.AssignCompanyToCollegeAsync(model.CollegeId, model.CompanyId);
            if (success)
                TempData["Message"] = "Company assigned to college successfully.";
            else
                TempData["Error"] = "Assignment failed or already exists.";
            return RedirectToAction("AssignCompanyToCollege");
        }
    }
}