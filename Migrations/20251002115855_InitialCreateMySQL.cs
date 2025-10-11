using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewCracker.Migrations
{
    public partial class InitialCreateMySQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Location = table.Column<string>(maxLength: 255, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Website = table.Column<string>(maxLength: 255, nullable: true),
                    LogoUrl = table.Column<string>(maxLength: 500, nullable: true),
                    CollegeId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Password = table.Column<string>(maxLength: 255, nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Role = table.Column<string>(maxLength: 50, nullable: true),
                    Organization = table.Column<string>(maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Bio = table.Column<string>(maxLength: 1000, nullable: true),
                    LinkedInProfile = table.Column<string>(maxLength: 255, nullable: true),
                    GitHubProfile = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodingQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 500, nullable: false),
                    Problem = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Solution = table.Column<string>(nullable: true),
                    SampleInput = table.Column<string>(nullable: true),
                    SampleOutput = table.Column<string>(nullable: true),
                    Topic = table.Column<string>(maxLength: 255, nullable: true),
                    Tags = table.Column<string>(maxLength: 500, nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CollegeId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Difficulty = table.Column<string>(maxLength: 50, nullable: true),
                    ContributorId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodingQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodingQuestions_Colleges_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "Colleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CodingQuestions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CodingQuestions_Users_ContributorId",
                        column: x => x.ContributorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MCQs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Question = table.Column<string>(nullable: false),
                    OptionA = table.Column<string>(maxLength: 500, nullable: false),
                    OptionB = table.Column<string>(maxLength: 500, nullable: false),
                    OptionC = table.Column<string>(maxLength: 500, nullable: false),
                    OptionD = table.Column<string>(maxLength: 500, nullable: false),
                    CorrectAnswer = table.Column<string>(maxLength: 1, nullable: false),
                    Explanation = table.Column<string>(maxLength: 1000, nullable: true),
                    Topic = table.Column<string>(maxLength: 255, nullable: true),
                    Tags = table.Column<string>(maxLength: 500, nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CollegeId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Difficulty = table.Column<string>(maxLength: 50, nullable: true),
                    ContributorId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MCQs_Colleges_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "Colleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MCQs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MCQs_Users_ContributorId",
                        column: x => x.ContributorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "IsActive", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(2127), "Premier engineering college", "/images/mit.jpg", true, "Pune", "MIT College of Engineering" },
                    { 2, new DateTime(2025, 9, 7, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(3080), "Government engineering college", "/images/coep.jpg", true, "Pune", "COEP Technological University" },
                    { 3, new DateTime(2025, 9, 12, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(3099), "Private technical university", "/images/vit.jpg", true, "Vellore", "VIT Vellore" },
                    { 4, new DateTime(2025, 9, 17, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(3103), "Indian Institute of Technology", "/images/iit.jpg", true, "Mumbai", "IIT Bombay" },
                    { 5, new DateTime(2025, 9, 22, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(3107), "National Institute of Technology", "/images/nit.jpg", true, "Trichy", "NIT Trichy" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CollegeId", "CreatedDate", "Description", "IsActive", "LogoUrl", "Name", "Website" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2025, 9, 2, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(6517), "Technology company", true, "/images/microsoft.jpg", "Microsoft", "https://microsoft.com" },
                    { 2, 0, new DateTime(2025, 9, 7, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(6999), "Search and technology company", true, "/images/google.jpg", "Google", "https://google.com" },
                    { 3, 0, new DateTime(2025, 9, 12, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(7014), "E-commerce and cloud computing", true, "/images/amazon.jpg", "Amazon", "https://amazon.com" },
                    { 4, 0, new DateTime(2025, 9, 17, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(7018), "Consumer electronics company", true, "/images/apple.jpg", "Apple", "https://apple.com" },
                    { 5, 0, new DateTime(2025, 9, 22, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(7022), "Social media and technology", true, "/images/meta.jpg", "Meta", "https://meta.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedDate", "Email", "GitHubProfile", "IsActive", "LinkedInProfile", "Name", "Organization", "Password", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 10, 2, 17, 28, 55, 231, DateTimeKind.Local).AddTicks(8723), "admin@admin.com", null, true, null, "System Admin", null, "admin123", null, "Admin" },
                    { 2, null, new DateTime(2025, 10, 2, 17, 28, 55, 231, DateTimeKind.Local).AddTicks(9093), "contributor@test.com", null, true, null, "John Doe", null, "test123", null, "Contributor" },
                    { 3, null, new DateTime(2025, 10, 2, 17, 28, 55, 231, DateTimeKind.Local).AddTicks(9103), "student@test.com", null, true, null, "Jane Smith", null, "test123", null, "Student" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodingQuestions_CollegeId",
                table: "CodingQuestions",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_CodingQuestions_CompanyId",
                table: "CodingQuestions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CodingQuestions_ContributorId",
                table: "CodingQuestions",
                column: "ContributorId");

            migrationBuilder.CreateIndex(
                name: "IX_MCQs_CollegeId",
                table: "MCQs",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_MCQs_CompanyId",
                table: "MCQs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MCQs_ContributorId",
                table: "MCQs",
                column: "ContributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodingQuestions");

            migrationBuilder.DropTable(
                name: "MCQs");

            migrationBuilder.DropTable(
                name: "Colleges");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
