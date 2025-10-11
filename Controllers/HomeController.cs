using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InterviewCracker.Models;
using InterviewCracker.Services;

namespace InterviewCracker.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ICollegeService _collegeService;
        private readonly ICompanyService _companyService;
        private readonly IMCQService _mcqService;
        private readonly ICodingQuestionService _codingQuestionService;

        public HomeController(ICollegeService collegeService,
                             ICompanyService companyService,
                             IMCQService mcqService,
                             ICodingQuestionService codingQuestionService)
        {
            _collegeService = collegeService;
            _companyService = companyService;
            _mcqService = mcqService;
            _codingQuestionService = codingQuestionService;
        }

        public async Task<IActionResult> Index(string searchTerm = "", string filterLocation = "")
        {
            var colleges = await _collegeService.SearchCollegesAsync(searchTerm, filterLocation);

            var model = new CollegeViewModel
            {
                Colleges = colleges.ToList(),
                SearchTerm = searchTerm,
                FilterLocation = filterLocation
            };

            return View(model);
        }

        public async Task<IActionResult> Companies(int collegeId, string searchTerm = "")
        {
            var college = await _collegeService.GetByIdAsync(collegeId);
            if (college == null)
            {
                return NotFound();
            }

            var companies = await _companyService.GetCompaniesByCollegeAsync(collegeId);
            
            if (!string.IsNullOrEmpty(searchTerm))
            {
                companies = companies.Where(c => c.Name.ToLower().Contains(searchTerm.ToLower()) ||
                                               c.Description.ToLower().Contains(searchTerm.ToLower())).ToList();
            }

            var model = new CompanyViewModel
            {
                Companies = companies.ToList(),
                College = college,
                SearchTerm = searchTerm
            };

            return View(model);
        }

        public async Task<IActionResult> Questions(int collegeId, int companyId, int? filterYear = null, string filterDifficulty = "", string searchTerm = "")
        {
            var college = await _collegeService.GetByIdAsync(collegeId);
            var company = await _companyService.GetByIdAsync(companyId);
            
            if (college == null || company == null)
            {
                return NotFound();
            }

            // Get actual questions from database
            var mcqs = await _mcqService.GetByCollegeAndCompanyAsync(collegeId, companyId);
            var codingQuestions = await _codingQuestionService.GetByCollegeAndCompanyAsync(collegeId, companyId);

            // Apply filters
            if (filterYear.HasValue)
            {
                mcqs = mcqs.Where(m => m.Year == filterYear.Value);
                codingQuestions = codingQuestions.Where(q => q.Year == filterYear.Value);
            }

            if (!string.IsNullOrEmpty(filterDifficulty))
            {
                mcqs = mcqs.Where(m => m.Difficulty == filterDifficulty);
                codingQuestions = codingQuestions.Where(q => q.Difficulty == filterDifficulty);
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                mcqs = mcqs.Where(m => m.Question.ToLower().Contains(searchTerm.ToLower()));
                codingQuestions = codingQuestions.Where(q => q.Title.ToLower().Contains(searchTerm.ToLower()) || 
                                                            q.Problem.ToLower().Contains(searchTerm.ToLower()));
            }

            var model = new QuestionsViewModel
            {
                MCQs = mcqs.ToList(),
                CodingQuestions = codingQuestions.ToList(),
                College = college,
                Company = company,
                FilterYear = filterYear,
                FilterDifficulty = filterDifficulty,
                SearchTerm = searchTerm
            };

            return View(model);
        }
    }
}