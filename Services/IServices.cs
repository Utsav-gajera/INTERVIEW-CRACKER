using InterviewCracker.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewCracker.Services
{
    public interface IUserService : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
        Task<User> AuthenticateAsync(string email, string password);
        Task<IEnumerable<User>> GetByRoleAsync(string role);
    }

    public interface ICollegeService : IRepository<College>
    {
        Task<IEnumerable<College>> GetActiveCollegesAsync();
        Task<IEnumerable<College>> SearchCollegesAsync(string searchTerm, string location);
        Task<bool> AssignCompanyToCollegeAsync(int collegeId, int companyId);
    }

    public interface ICompanyService : IRepository<Company>
    {
        Task<IEnumerable<Company>> GetActiveCompaniesAsync();
        Task<IEnumerable<Company>> GetCompaniesByCollegeAsync(int collegeId);
        Task<IEnumerable<Company>> SearchCompaniesAsync(string searchTerm);
    }

    public interface ICodingQuestionService : IRepository<CodingQuestion>
    {
        Task<IEnumerable<CodingQuestion>> GetByCollegeAndCompanyAsync(int collegeId, int companyId);
        Task<IEnumerable<CodingQuestion>> GetByContributorAsync(int contributorId);
        Task<IEnumerable<CodingQuestion>> SearchQuestionsAsync(string searchTerm, string difficulty, int? year);
    }

    public interface IMCQService : IRepository<MCQ>
    {
        Task<IEnumerable<MCQ>> GetByCollegeAndCompanyAsync(int collegeId, int companyId);
        Task<IEnumerable<MCQ>> GetByContributorAsync(int contributorId);
        Task<IEnumerable<MCQ>> SearchMCQsAsync(string searchTerm, string difficulty, int? year);
    }
}