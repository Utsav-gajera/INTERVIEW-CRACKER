using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InterviewCracker.Models;
using InterviewCracker.Services;

namespace InterviewCracker.Controllers
{
    [Authorize(Roles = "Contributor")]
    public class ContributorController : Controller
    {
        private readonly IMCQService _mcqService;
        private readonly ICodingQuestionService _codingQuestionService;
        private readonly ICollegeService _collegeService;
        private readonly ICompanyService _companyService;

        public ContributorController(
            IMCQService mcqService,
            ICodingQuestionService codingQuestionService,
            ICollegeService collegeService,
            ICompanyService companyService)
        {
            _mcqService = mcqService;
            _codingQuestionService = codingQuestionService;
            _collegeService = collegeService;
            _companyService = companyService;
        }

        public async Task<IActionResult> Dashboard()
        {
            var contributorId = int.Parse(User.FindFirstValue("UserId"));
            var mcqs = await _mcqService.GetByContributorAsync(contributorId);
            var codingQuestions = await _codingQuestionService.GetByContributorAsync(contributorId);
            
            ViewBag.TotalMCQs = mcqs.Count();
            ViewBag.TotalCodingQuestions = codingQuestions.Count();
            
            return View();
        }

        public async Task<IActionResult> MyQuestions()
        {
            var contributorId = int.Parse(User.FindFirstValue("UserId"));
            var model = new QuestionsViewModel
            {
                MCQs = (await _mcqService.GetByContributorAsync(contributorId)).ToList(),
                CodingQuestions = (await _codingQuestionService.GetByContributorAsync(contributorId)).ToList()
            };
            
            return View(model);
        }

        public async Task<IActionResult> AddMCQ()
        {
            ViewBag.Colleges = await _collegeService.GetAllAsync();
            ViewBag.Companies = await _companyService.GetAllAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMCQ(MCQ model)
        {

            if (model.CollegeId == 0)
            {
                ModelState.AddModelError(nameof(model.CollegeId), "Please select a college.");
            }
            
            if (model.CompanyId == 0)
            {
                ModelState.AddModelError(nameof(model.CompanyId), "Please select a company.");
            }
            
            if (model.Year == 0)
            {
                ModelState.AddModelError(nameof(model.Year), "Please provide a valid year.");
            }
            
            if (string.IsNullOrWhiteSpace(model.Difficulty))
            {
                ModelState.AddModelError(nameof(model.Difficulty), "Please select a difficulty level.");
            }

            
            if (ModelState.IsValid)
            {

                
                model.ContributorId = int.Parse(User.FindFirstValue("UserId"));
                model.CreatedDate = DateTime.Now;
                model.IsActive = true;
                model.IsApproved = true; // Auto-approve MCQs
                await _mcqService.AddAsync(model);
                
                TempData["Message"] = "MCQ added successfully!";
                return RedirectToAction("MyQuestions");
            }
            
            ViewBag.Colleges = await _collegeService.GetAllAsync();
            ViewBag.Companies = await _companyService.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> AddCodingQuestion()
        {
            ViewBag.Colleges = await _collegeService.GetAllAsync();
            // Don't load companies initially - they will be loaded via AJAX based on college selection
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCodingQuestion(CodingQuestion model)
        {
            // Add custom validation for required fields that are int
            if (model.CollegeId == 0)
            {
                ModelState.AddModelError(nameof(model.CollegeId), "Please select a college.");
            }
            
            if (model.CompanyId == 0)
            {
                ModelState.AddModelError(nameof(model.CompanyId), "Please select a company.");
            }
            
            if (model.Year == 0)
            {
                ModelState.AddModelError(nameof(model.Year), "Please provide a valid year.");
            }
            
            if (string.IsNullOrWhiteSpace(model.Difficulty))
            {
                ModelState.AddModelError(nameof(model.Difficulty), "Please select a difficulty level.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.ContributorId = int.Parse(User.FindFirstValue("UserId"));
                    model.CreatedDate = DateTime.Now;
                    model.IsActive = true;
                    model.IsApproved = true; // Auto-approve coding questions
                    
                    // Debug: Log the model values
                    System.Diagnostics.Debug.WriteLine($"Adding coding question: Title={model.Title}, CollegeId={model.CollegeId}, CompanyId={model.CompanyId}, Year={model.Year}");
                    
                    await _codingQuestionService.AddAsync(model);
                    
                    TempData["Message"] = "Coding question added successfully!";
                    return RedirectToAction("MyQuestions");
                }
                catch (Exception ex)
                {
                    // Improved error handling with specific error details
                    var errorMessage = $"An error occurred while saving the coding question: {ex.Message}";
                    if (ex.InnerException != null)
                    {
                        errorMessage += $" Inner exception: {ex.InnerException.Message}";
                    }
                    
                    ModelState.AddModelError("", errorMessage);
                    TempData["Error"] = errorMessage;
                }
            }
            else
            {
                // Debug: Log validation errors
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                System.Diagnostics.Debug.WriteLine($"Validation errors: {string.Join(", ", errors)}");
                TempData["Error"] = "Please correct the validation errors and try again.";
            }
            
            ViewBag.Colleges = await _collegeService.GetAllAsync();
            ViewBag.Companies = await _companyService.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> EditMCQ(int id)
        {
            var contributorId = int.Parse(User.FindFirstValue("UserId"));
            var mcqs = await _mcqService.GetByContributorAsync(contributorId);
            var mcq = mcqs.FirstOrDefault(m => m.Id == id);
            
            if (mcq == null)
            {
                return NotFound();
            }
            
            ViewBag.Colleges = await _collegeService.GetAllAsync();
            ViewBag.Companies = await _companyService.GetAllAsync();
            return View(mcq);
        }

        [HttpPost]
        public async Task<IActionResult> EditMCQ(MCQ model)
        {
            if (ModelState.IsValid)
            {
                var contributorId = int.Parse(User.FindFirstValue("UserId"));
                
                // Check if the MCQ exists and belongs to the contributor
                var existingMcq = await _mcqService.GetByIdAsync(model.Id);
                if (existingMcq == null || existingMcq.ContributorId != contributorId)
                {
                    return NotFound();
                }
                
                // Update the existing entity's properties to avoid tracking conflicts
                existingMcq.Question = model.Question;
                existingMcq.OptionA = model.OptionA;
                existingMcq.OptionB = model.OptionB;
                existingMcq.OptionC = model.OptionC;
                existingMcq.OptionD = model.OptionD;
                existingMcq.CorrectAnswer = model.CorrectAnswer;
                existingMcq.Explanation = model.Explanation;
                existingMcq.Difficulty = model.Difficulty;
                existingMcq.Topic = model.Topic;
                existingMcq.Tags = model.Tags;
                existingMcq.Year = model.Year;
                existingMcq.CollegeId = model.CollegeId;
                existingMcq.CompanyId = model.CompanyId;
                existingMcq.IsApproved = true; // Keep auto-approval for edits
                
                await _mcqService.UpdateAsync(existingMcq);
                
                TempData["Message"] = "MCQ updated successfully!";
                return RedirectToAction("MyQuestions");
            }
            
            ViewBag.Colleges = await _collegeService.GetAllAsync();
            ViewBag.Companies = await _companyService.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> EditCodingQuestion(int id)
        {
            var contributorId = int.Parse(User.FindFirstValue("UserId"));
            var questions = await _codingQuestionService.GetByContributorAsync(contributorId);
            var question = questions.FirstOrDefault(c => c.Id == id);
            
            if (question == null)
            {
                return NotFound();
            }
            
            ViewBag.Colleges = await _collegeService.GetAllAsync();
            ViewBag.Companies = await _companyService.GetAllAsync();
            return View(question);
        }

        [HttpPost]
        public async Task<IActionResult> EditCodingQuestion(CodingQuestion model)
        {
            if (ModelState.IsValid)
            {
                var contributorId = int.Parse(User.FindFirstValue("UserId"));
                
                // Check if the coding question exists and belongs to the contributor
                var existingQuestion = await _codingQuestionService.GetByIdAsync(model.Id);
                if (existingQuestion == null || existingQuestion.ContributorId != contributorId)
                {
                    return NotFound();
                }
                
                // Update the existing entity's properties to avoid tracking conflicts
                existingQuestion.Title = model.Title;
                existingQuestion.Problem = model.Problem;
                existingQuestion.Description = model.Description;
                existingQuestion.Solution = model.Solution;
                existingQuestion.SampleInput = model.SampleInput;
                existingQuestion.SampleOutput = model.SampleOutput;
                existingQuestion.Difficulty = model.Difficulty;
                existingQuestion.Topic = model.Topic;
                existingQuestion.Tags = model.Tags;
                existingQuestion.Year = model.Year;
                existingQuestion.CollegeId = model.CollegeId;
                existingQuestion.CompanyId = model.CompanyId;
                existingQuestion.IsApproved = true; // Keep auto-approval for edits
                
                await _codingQuestionService.UpdateAsync(existingQuestion);
                
                TempData["Message"] = "Coding question updated successfully!";
                return RedirectToAction("MyQuestions");
            }
            
            ViewBag.Colleges = await _collegeService.GetAllAsync();
            ViewBag.Companies = await _companyService.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> DeleteMCQ(int id)
        {
            var contributorId = int.Parse(User.FindFirstValue("UserId"));
            var mcq = await _mcqService.GetByIdAsync(id);
            
            if (mcq != null && mcq.ContributorId == contributorId)
            {
                await _mcqService.DeleteAsync(id);
                TempData["Message"] = "MCQ deleted successfully!";
            }
            
            return RedirectToAction("MyQuestions");
        }

        public async Task<IActionResult> DeleteCodingQuestion(int id)
        {
            var contributorId = int.Parse(User.FindFirstValue("UserId"));
            var question = await _codingQuestionService.GetByIdAsync(id);
            
            if (question != null && question.ContributorId == contributorId)
            {
                await _codingQuestionService.DeleteAsync(id);
                TempData["Message"] = "Coding question deleted successfully!";
            }
            
            return RedirectToAction("MyQuestions");
        }

        // API endpoint to get companies by college ID (for AJAX calls)
        [HttpGet]
        public async Task<IActionResult> GetCompaniesByCollege(int collegeId)
        {
            var companies = await _companyService.GetCompaniesByCollegeAsync(collegeId);
            var companyList = companies.Select(c => new { id = c.Id, name = c.Name }).ToList();
            return Json(companyList);
        }
    }
}