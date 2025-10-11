using System;
using Microsoft.EntityFrameworkCore;
using InterviewCracker.Models;

namespace InterviewCracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CollegeCompany> CollegeCompanies { get; set; }
        public DbSet<CodingQuestion> CodingQuestions { get; set; }
        public DbSet<MCQ> MCQs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User entity configuration
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(255);
                entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Role).HasMaxLength(50);
                entity.Property(e => e.Organization).HasMaxLength(255);
                entity.Property(e => e.PhoneNumber).HasMaxLength(20);
                entity.Property(e => e.Bio).HasMaxLength(1000);
                entity.Property(e => e.LinkedInProfile).HasMaxLength(255);
                entity.Property(e => e.GitHubProfile).HasMaxLength(255);
            });

            // College entity configuration
            modelBuilder.Entity<College>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Location).HasMaxLength(255);
                entity.Property(e => e.ImageUrl).HasMaxLength(500);
            });

            // Company entity configuration
            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Website).HasMaxLength(255);
                entity.Property(e => e.LogoUrl).HasMaxLength(500);
            });

            // CollegeCompany entity configuration (Many-to-Many junction table)
            modelBuilder.Entity<CollegeCompany>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => new { e.CollegeId, e.CompanyId }).IsUnique();
                
                entity.HasOne(e => e.College)
                      .WithMany(c => c.CollegeCompanies)
                      .HasForeignKey(e => e.CollegeId)
                      .OnDelete(DeleteBehavior.Cascade);
                      
                entity.HasOne(e => e.Company)
                      .WithMany(c => c.CollegeCompanies)
                      .HasForeignKey(e => e.CompanyId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // CodingQuestion entity configuration
            modelBuilder.Entity<CodingQuestion>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired().HasMaxLength(500);
                entity.Property(e => e.Description).IsRequired();
                entity.Property(e => e.Solution);
                entity.Property(e => e.Difficulty).HasMaxLength(50);
                entity.Property(e => e.Topic).HasMaxLength(255);
                entity.Property(e => e.Tags).HasMaxLength(500);
                
                // Foreign key relationships
                entity.HasOne<College>()
                      .WithMany()
                      .HasForeignKey(e => e.CollegeId)
                      .OnDelete(DeleteBehavior.Restrict);
                      
                entity.HasOne<Company>()
                      .WithMany()
                      .HasForeignKey(e => e.CompanyId)
                      .OnDelete(DeleteBehavior.Restrict);
                      
                entity.HasOne<User>()
                      .WithMany()
                      .HasForeignKey(e => e.ContributorId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // MCQ entity configuration
            modelBuilder.Entity<MCQ>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Question).IsRequired();
                entity.Property(e => e.OptionA).IsRequired().HasMaxLength(500);
                entity.Property(e => e.OptionB).IsRequired().HasMaxLength(500);
                entity.Property(e => e.OptionC).IsRequired().HasMaxLength(500);
                entity.Property(e => e.OptionD).IsRequired().HasMaxLength(500);
                entity.Property(e => e.CorrectAnswer).IsRequired().HasMaxLength(1);
                entity.Property(e => e.Explanation).HasMaxLength(1000);
                entity.Property(e => e.Difficulty).HasMaxLength(50);
                entity.Property(e => e.Topic).HasMaxLength(255);
                entity.Property(e => e.Tags).HasMaxLength(500);
                
                // Foreign key relationships
                entity.HasOne<College>()
                      .WithMany()
                      .HasForeignKey(e => e.CollegeId)
                      .OnDelete(DeleteBehavior.Restrict);
                      
                entity.HasOne<Company>()
                      .WithMany()
                      .HasForeignKey(e => e.CompanyId)
                      .OnDelete(DeleteBehavior.Restrict);
                      
                entity.HasOne<User>()
                      .WithMany()
                      .HasForeignKey(e => e.ContributorId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "admin@admin.com", Password = "admin123", Name = "System Admin", Role = "Admin", IsActive = true, CreatedDate = DateTime.Now },
                new User { Id = 2, Email = "contributor@test.com", Password = "test123", Name = "John Doe", Role = "Contributor", IsActive = true, CreatedDate = DateTime.Now },
                new User { Id = 3, Email = "student@test.com", Password = "test123", Name = "Jane Smith", Role = "Student", IsActive = true, CreatedDate = DateTime.Now }
            );

            // Seed Colleges
            modelBuilder.Entity<College>().HasData(
                new College { Id = 1, Name = "MIT College of Engineering", Description = "Premier engineering college", Location = "Pune", ImageUrl = "/images/colleges/MIT College of Engineering.jpg", IsActive = true, CreatedDate = DateTime.Now.AddDays(-30) },
                new College { Id = 2, Name = "COEP Technological University", Description = "Government engineering college", Location = "Pune", ImageUrl = "/images/colleges/COEP Technological University.jpg", IsActive = true, CreatedDate = DateTime.Now.AddDays(-25) },
                new College { Id = 3, Name = "VIT Vellore", Description = "Private technical university", Location = "Vellore", ImageUrl = "/images/colleges/VIT Vellore.jpg", IsActive = true, CreatedDate = DateTime.Now.AddDays(-20) },
                new College { Id = 4, Name = "IIT Bombay", Description = "Indian Institute of Technology", Location = "Mumbai", ImageUrl = "/images/colleges/IIT Bombay.webp", IsActive = true, CreatedDate = DateTime.Now.AddDays(-15) },
                new College { Id = 5, Name = "NIT Trichy", Description = "National Institute of Technology", Location = "Trichy", ImageUrl = "/images/colleges/NIT Trichy.jpg", IsActive = true, CreatedDate = DateTime.Now.AddDays(-10) }
            );

            // Seed Companies (no CollegeId needed anymore)
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Microsoft", Description = "Technology company", Website = "https://microsoft.com", LogoUrl = "/images/companies/microsoft.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-30) },
                new Company { Id = 2, Name = "Google", Description = "Search and technology company", Website = "https://google.com", LogoUrl = "/images/companies/google.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-25) },
                new Company { Id = 3, Name = "Amazon", Description = "E-commerce and cloud computing", Website = "https://amazon.com", LogoUrl = "/images/companies/amazon.jpg", IsActive = true, CreatedDate = DateTime.Now.AddDays(-20) },
                new Company { Id = 4, Name = "Apple", Description = "Consumer electronics company", Website = "https://apple.com", LogoUrl = "/images/companies/apple.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-15) },
                new Company { Id = 5, Name = "Meta", Description = "Social media and technology", Website = "https://meta.com", LogoUrl = "/images/companies/meta.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-10) },
                new Company { Id = 6, Name = "Tesla", Description = "Electric vehicles and clean energy", Website = "https://tesla.com", LogoUrl = "/images/companies/tesla.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-8) },
                new Company { Id = 7, Name = "Netflix", Description = "Streaming entertainment service", Website = "https://netflix.com", LogoUrl = "/images/companies/Netflix.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-6) },
                new Company { Id = 8, Name = "TCS", Description = "IT Services and Consulting", Website = "https://tcs.com", LogoUrl = "/images/companies/tcs.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-5) },
                new Company { Id = 9, Name = "Infosys", Description = "IT Services and Digital transformation", Website = "https://infosys.com", LogoUrl = "/images/companies/Infosys.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-4) },
                new Company { Id = 10, Name = "Wipro", Description = "IT Services and Consulting", Website = "https://wipro.com", LogoUrl = "/images/companies/Wipro.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-3) },
                new Company { Id = 11, Name = "Goldman Sachs", Description = "Investment banking and financial services", Website = "https://goldmansachs.com", LogoUrl = "/images/companies/Goldman Sachs.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-2) },
                new Company { Id = 12, Name = "IBM", Description = "Technology and consulting services", Website = "https://ibm.com", LogoUrl = "/images/companies/ibm.png", IsActive = true, CreatedDate = DateTime.Now.AddDays(-1) }
            );

            // Seed College-Company relationships (Many-to-Many)
            // This allows multiple colleges to have the same company!
            modelBuilder.Entity<CollegeCompany>().HasData(
                // MIT College of Engineering (ID = 1)
                new CollegeCompany { Id = 1, CollegeId = 1, CompanyId = 1, IsActive = true, CreatedDate = DateTime.Now }, // Microsoft
                new CollegeCompany { Id = 2, CollegeId = 1, CompanyId = 2, IsActive = true, CreatedDate = DateTime.Now }, // Google
                new CollegeCompany { Id = 3, CollegeId = 1, CompanyId = 3, IsActive = true, CreatedDate = DateTime.Now }, // Amazon
                new CollegeCompany { Id = 4, CollegeId = 1, CompanyId = 4, IsActive = true, CreatedDate = DateTime.Now }, // Apple
                new CollegeCompany { Id = 5, CollegeId = 1, CompanyId = 12, IsActive = true, CreatedDate = DateTime.Now }, // IBM

                // COEP Technological University (ID = 2)
                new CollegeCompany { Id = 6, CollegeId = 2, CompanyId = 2, IsActive = true, CreatedDate = DateTime.Now }, // Google
                new CollegeCompany { Id = 7, CollegeId = 2, CompanyId = 3, IsActive = true, CreatedDate = DateTime.Now }, // Amazon
                new CollegeCompany { Id = 8, CollegeId = 2, CompanyId = 8, IsActive = true, CreatedDate = DateTime.Now }, // TCS
                new CollegeCompany { Id = 9, CollegeId = 2, CompanyId = 9, IsActive = true, CreatedDate = DateTime.Now }, // Infosys
                new CollegeCompany { Id = 10, CollegeId = 2, CompanyId = 12, IsActive = true, CreatedDate = DateTime.Now }, // IBM

                // VIT Vellore (ID = 3) - *** GOOGLE IS HERE! ***
                new CollegeCompany { Id = 11, CollegeId = 3, CompanyId = 2, IsActive = true, CreatedDate = DateTime.Now }, // Google ⭐
                new CollegeCompany { Id = 12, CollegeId = 3, CompanyId = 4, IsActive = true, CreatedDate = DateTime.Now }, // Apple
                new CollegeCompany { Id = 13, CollegeId = 3, CompanyId = 5, IsActive = true, CreatedDate = DateTime.Now }, // Meta
                new CollegeCompany { Id = 14, CollegeId = 3, CompanyId = 6, IsActive = true, CreatedDate = DateTime.Now }, // Tesla
                new CollegeCompany { Id = 15, CollegeId = 3, CompanyId = 7, IsActive = true, CreatedDate = DateTime.Now }, // Netflix

                // IIT Bombay (ID = 4)
                new CollegeCompany { Id = 16, CollegeId = 4, CompanyId = 1, IsActive = true, CreatedDate = DateTime.Now }, // Microsoft
                new CollegeCompany { Id = 17, CollegeId = 4, CompanyId = 2, IsActive = true, CreatedDate = DateTime.Now }, // Google
                new CollegeCompany { Id = 18, CollegeId = 4, CompanyId = 3, IsActive = true, CreatedDate = DateTime.Now }, // Amazon
                new CollegeCompany { Id = 19, CollegeId = 4, CompanyId = 11, IsActive = true, CreatedDate = DateTime.Now }, // Goldman Sachs
                new CollegeCompany { Id = 20, CollegeId = 4, CompanyId = 12, IsActive = true, CreatedDate = DateTime.Now }, // IBM

                // NIT Trichy (ID = 5)
                new CollegeCompany { Id = 21, CollegeId = 5, CompanyId = 2, IsActive = true, CreatedDate = DateTime.Now }, // Google
                new CollegeCompany { Id = 22, CollegeId = 5, CompanyId = 8, IsActive = true, CreatedDate = DateTime.Now }, // TCS
                new CollegeCompany { Id = 23, CollegeId = 5, CompanyId = 9, IsActive = true, CreatedDate = DateTime.Now }, // Infosys
                new CollegeCompany { Id = 24, CollegeId = 5, CompanyId = 10, IsActive = true, CreatedDate = DateTime.Now }, // Wipro
                new CollegeCompany { Id = 25, CollegeId = 5, CompanyId = 12, IsActive = true, CreatedDate = DateTime.Now }  // IBM
            );

            // Seed Sample MCQs
            modelBuilder.Entity<MCQ>().HasData(
                new MCQ
                {
                    Id = 1,
                    Question = "What is the time complexity of binary search?",
                    OptionA = "O(n)",
                    OptionB = "O(log n)",
                    OptionC = "O(n^2)",
                    OptionD = "O(1)",
                    CorrectAnswer = "B",
                    Explanation = "Binary search divides the search space in half with each comparison, resulting in O(log n) time complexity.",
                    Difficulty = "Medium",
                    Topic = "Algorithms",
                    Tags = "binary search, time complexity",
                    Year = 2023,
                    CollegeId = 3, // VIT Vellore
                    CompanyId = 2, // Google
                    ContributorId = 2, // contributor@test.com
                    IsActive = true,
                    IsApproved = true,
                    CreatedDate = DateTime.Now.AddDays(-5)
                },
                new MCQ
                {
                    Id = 2,
                    Question = "Which data structure uses LIFO principle?",
                    OptionA = "Queue",
                    OptionB = "Stack",
                    OptionC = "Array",
                    OptionD = "Linked List",
                    CorrectAnswer = "B",
                    Explanation = "Stack follows Last In First Out (LIFO) principle where the last element added is the first one to be removed.",
                    Difficulty = "Easy",
                    Topic = "Data Structures",
                    Tags = "stack, LIFO",
                    Year = 2023,
                    CollegeId = 3, // VIT Vellore
                    CompanyId = 2, // Google
                    ContributorId = 2, // contributor@test.com
                    IsActive = true,
                    IsApproved = true,
                    CreatedDate = DateTime.Now.AddDays(-3)
                },
                new MCQ
                {
                    Id = 3,
                    Question = "What does SQL stand for?",
                    OptionA = "Structured Query Language",
                    OptionB = "Simple Query Language",
                    OptionC = "Sequential Query Language",
                    OptionD = "Standard Query Language",
                    CorrectAnswer = "A",
                    Explanation = "SQL stands for Structured Query Language, used for managing relational databases.",
                    Difficulty = "Easy",
                    Topic = "Database",
                    Tags = "SQL, database",
                    Year = 2024,
                    CollegeId = 1, // MIT College
                    CompanyId = 1, // Microsoft
                    ContributorId = 2, // contributor@test.com
                    IsActive = true,
                    IsApproved = true,
                    CreatedDate = DateTime.Now.AddDays(-2)
                }
            );

            // Seed Sample Coding Questions
            modelBuilder.Entity<CodingQuestion>().HasData(
                new CodingQuestion
                {
                    Id = 1,
                    Title = "Two Sum",
                    Problem = "Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.",
                    Description = "Find two numbers in an array that add up to a target sum and return their indices.",
                    Solution = "Use a hash map to store complements and their indices for O(n) solution.",
                    SampleInput = "nums = [2,7,11,15], target = 9",
                    SampleOutput = "[0,1]",
                    Difficulty = "Easy",
                    Topic = "Arrays",
                    Tags = "hash map, two pointers",
                    Year = 2023,
                    CollegeId = 3, // VIT Vellore
                    CompanyId = 2, // Google
                    ContributorId = 2, // contributor@test.com
                    IsActive = true,
                    IsApproved = true,
                    CreatedDate = DateTime.Now.AddDays(-4)
                },
                new CodingQuestion
                {
                    Id = 2,
                    Title = "Reverse Linked List",
                    Problem = "Given the head of a singly linked list, reverse the list, and return the reversed list.",
                    Description = "Reverse the direction of pointers in a singly linked list.",
                    Solution = "Use iterative approach with three pointers: prev, current, and next.",
                    SampleInput = "head = [1,2,3,4,5]",
                    SampleOutput = "[5,4,3,2,1]",
                    Difficulty = "Medium",
                    Topic = "Linked Lists",
                    Tags = "linked list, pointers",
                    Year = 2024,
                    CollegeId = 1, // MIT College
                    CompanyId = 1, // Microsoft
                    ContributorId = 2, // contributor@test.com
                    IsActive = true,
                    IsApproved = true,
                    CreatedDate = DateTime.Now.AddDays(-1)
                }
            );
        }
    }
}