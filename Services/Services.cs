using Microsoft.EntityFrameworkCore;
using InterviewCracker.Data;
using InterviewCracker.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewCracker.Services
{
    public class UserService : Repository<User>, IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> AuthenticateAsync(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password && u.IsActive);
            return user;
        }

        public async Task<IEnumerable<User>> GetByRoleAsync(string role)
        {
            return await _context.Users.Where(u => u.Role == role && u.IsActive).ToListAsync();
        }
    }

    public class CollegeService : Repository<College>, ICollegeService
    {
        private readonly ApplicationDbContext _context;

        public CollegeService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<College>> GetActiveCollegesAsync()
        {
            return await _context.Colleges.Where(c => c.IsActive).OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<IEnumerable<College>> SearchCollegesAsync(string searchTerm, string location)
        {
            var query = _context.Colleges.Where(c => c.IsActive);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(c => c.Name.Contains(searchTerm) || c.Description.Contains(searchTerm));
            }

            if (!string.IsNullOrEmpty(location))
            {
                query = query.Where(c => c.Location == location);
            }

            return await query.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<bool> AssignCompanyToCollegeAsync(int collegeId, int companyId)
        {
            // Check if relationship already exists
            var exists = await _context.CollegeCompanies.AnyAsync(cc => cc.CollegeId == collegeId && cc.CompanyId == companyId && cc.IsActive);
            if (exists)
                return false;
            var cc = new CollegeCompany
            {
                CollegeId = collegeId,
                CompanyId = companyId,
                IsActive = true
            };
            _context.CollegeCompanies.Add(cc);
            await _context.SaveChangesAsync();
            return true;
        }
    }

    public class CompanyService : Repository<Company>, ICompanyService
    {
        private readonly ApplicationDbContext _context;

        public CompanyService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Company>> GetActiveCompaniesAsync()
        {
            return await _context.Companies.Where(c => c.IsActive).OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<IEnumerable<Company>> GetCompaniesByCollegeAsync(int collegeId)
        {
            // First get companies with explicit college relationships
            var relatedCompanies = await _context.CollegeCompanies
                .Where(cc => cc.CollegeId == collegeId && cc.IsActive)
                .Include(cc => cc.Company)
                .Where(cc => cc.Company.IsActive)
                .Select(cc => cc.Company)
                .ToListAsync();

            // If no related companies found, return all active companies
            // This allows more flexibility for coding questions
            if (!relatedCompanies.Any())
            {
                return await _context.Companies
                    .Where(c => c.IsActive)
                    .OrderBy(c => c.Name)
                    .ToListAsync();
            }

            return relatedCompanies.OrderBy(c => c.Name);
        }

        public async Task<IEnumerable<Company>> SearchCompaniesAsync(string searchTerm)
        {
            var query = _context.Companies.Where(c => c.IsActive);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(c => c.Name.Contains(searchTerm) || c.Description.Contains(searchTerm));
            }

            return await query.OrderBy(c => c.Name).ToListAsync();
        }
    }

    public class CodingQuestionService : Repository<CodingQuestion>, ICodingQuestionService
    {
        private readonly ApplicationDbContext _context;

        public CodingQuestionService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CodingQuestion>> GetByCollegeAndCompanyAsync(int collegeId, int companyId)
        {
            return await _context.CodingQuestions
                .Where(q => q.CollegeId == collegeId && q.CompanyId == companyId && q.IsActive)
                .OrderByDescending(q => q.CreatedDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<CodingQuestion>> GetByContributorAsync(int contributorId)
        {
            return await _context.CodingQuestions
                .Where(q => q.ContributorId == contributorId)
                .OrderByDescending(q => q.CreatedDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<CodingQuestion>> SearchQuestionsAsync(string searchTerm, string difficulty, int? year)
        {
            var query = _context.CodingQuestions.Where(q => q.IsActive);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(q => q.Title.Contains(searchTerm) || q.Description.Contains(searchTerm) || q.Tags.Contains(searchTerm));
            }

            if (!string.IsNullOrEmpty(difficulty))
            {
                query = query.Where(q => q.Difficulty == difficulty);
            }

            if (year.HasValue)
            {
                query = query.Where(q => q.Year == year.Value);
            }

            return await query.OrderByDescending(q => q.CreatedDate).ToListAsync();
        }
    }

    public class MCQService : Repository<MCQ>, IMCQService
    {
        private readonly ApplicationDbContext _context;

        public MCQService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MCQ>> GetByCollegeAndCompanyAsync(int collegeId, int companyId)
        {
            return await _context.MCQs
                .Where(q => q.CollegeId == collegeId && q.CompanyId == companyId && q.IsActive)
                .OrderByDescending(q => q.CreatedDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<MCQ>> GetByContributorAsync(int contributorId)
        {
            return await _context.MCQs
                .Where(q => q.ContributorId == contributorId)
                .OrderByDescending(q => q.CreatedDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<MCQ>> SearchMCQsAsync(string searchTerm, string difficulty, int? year)
        {
            var query = _context.MCQs.Where(q => q.IsActive);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(q => q.Question.Contains(searchTerm) || q.Tags.Contains(searchTerm));
            }

            if (!string.IsNullOrEmpty(difficulty))
            {
                query = query.Where(q => q.Difficulty == difficulty);
            }

            if (year.HasValue)
            {
                query = query.Where(q => q.Year == year.Value);
            }

            return await query.OrderByDescending(q => q.CreatedDate).ToListAsync();
        }
    }
}