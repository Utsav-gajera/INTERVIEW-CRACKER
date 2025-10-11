using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InterviewCracker.Models;
using InterviewCracker.Services;

namespace InterviewCracker.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + "InterviewCracker_Salt"));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // First try with plain text password (for existing users)
                var user = await _userService.AuthenticateAsync(model.Email, model.Password);
                
                // If that fails, try with hashed password (for new users)
                if (user == null)
                {
                    var hashedPassword = HashPassword(model.Password);
                    user = await _userService.AuthenticateAsync(model.Email, hashedPassword);
                }
                
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role),
                        new Claim("UserId", user.Id.ToString())
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), authProperties);

                    // Redirect based on role
                    if (user.Role == "Admin")
                        return RedirectToAction("Dashboard", "Admin");
                    else if (user.Role == "Contributor")
                        return RedirectToAction("Dashboard", "Contributor");
                    else
                        return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password.");
                }
            }
            
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userService.GetByEmailAsync(model.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError("", "Email already exists.");
                    return View(model);
                }

                var user = new User
                {
                    Email = model.Email,
                    Password = HashPassword(model.Password),
                    Name = model.Name,
                    Role = "Student",
                    CreatedDate = DateTime.Now,
                    IsActive = true
                };

                await _userService.AddAsync(user);
                
                TempData["Message"] = "Registration successful! Please login.";
                return RedirectToAction("Login");
            }
            
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var userIdClaim = User.FindFirst("UserId")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
                return RedirectToAction("Login");

            var user = await _userService.GetByIdAsync(userId);
            if (user == null)
                return RedirectToAction("Login");

            var model = new ProfileViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role,
                Organization = user.Organization,
                PhoneNumber = user.PhoneNumber,
                Bio = user.Bio,
                LinkedInProfile = user.LinkedInProfile,
                GitHubProfile = user.GitHubProfile
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Profile(ProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please correct the validation errors and try again.";
                return View(model);
            }

            var userIdClaim = User.FindFirst("UserId")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
                return RedirectToAction("Login");

            var user = await _userService.GetByIdAsync(userId);
            if (user == null)
                return RedirectToAction("Login");

            try
            {
                // Check if email is already taken by another user
                var existingUser = await _userService.GetByEmailAsync(model.Email);
                if (existingUser != null && existingUser.Id != userId)
                {
                    ModelState.AddModelError("Email", "This email is already in use by another user.");
                    TempData["Error"] = "Email is already in use by another user.";
                    return View(model);
                }

                // Update user information
                user.Name = model.Name?.Trim();
                user.Email = model.Email?.Trim();
                user.Organization = model.Organization?.Trim();
                user.PhoneNumber = model.PhoneNumber?.Trim();
                user.Bio = model.Bio?.Trim();
                user.LinkedInProfile = model.LinkedInProfile?.Trim();
                user.GitHubProfile = model.GitHubProfile?.Trim();

                await _userService.UpdateAsync(user);

                // Update claims if name or email changed
                var currentName = User.Identity.Name;
                if (currentName != user.Name)
                {
                    // Sign out and sign back in with updated claims
                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role),
                        new Claim("UserId", user.Id.ToString())
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), authProperties);
                }

                TempData["Message"] = "Profile updated successfully!";
                return RedirectToAction("Profile");
            }
            catch (Exception)
            {
                TempData["Error"] = "An error occurred while updating your profile. Please try again.";
                return View(model);
            }
        }

        [Authorize]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var userIdClaim = User.FindFirst("UserId")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
                return RedirectToAction("Login");

            var user = await _userService.GetByIdAsync(userId);
            if (user == null)
                return RedirectToAction("Login");

            // Verify current password (support both plain text and hashed passwords)
            bool isCurrentPasswordValid = false;
            
            // First try plain text comparison (for existing users)
            if (user.Password == model.CurrentPassword)
            {
                isCurrentPasswordValid = true;
            }
            else
            {
                // Try hashed password comparison (for users with hashed passwords)
                var hashedCurrentPassword = HashPassword(model.CurrentPassword);
                if (user.Password == hashedCurrentPassword)
                {
                    isCurrentPasswordValid = true;
                }
            }

            if (!isCurrentPasswordValid)
            {
                ModelState.AddModelError("CurrentPassword", "Current password is incorrect.");
                return View(model);
            }

            // Update password with hashing (no strength check)
            user.Password = HashPassword(model.NewPassword);
            await _userService.UpdateAsync(user);

            TempData["Message"] = "Password changed successfully!";
            return RedirectToAction("Profile");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}