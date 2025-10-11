using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewCracker.Migrations
{
    public partial class AddSampleMCQsAndCodingQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CodingQuestions",
                columns: new[] { "Id", "CollegeId", "CompanyId", "ContributorId", "CreatedDate", "Description", "Difficulty", "IsActive", "IsApproved", "Problem", "SampleInput", "SampleOutput", "Solution", "Tags", "Title", "Topic", "Year" },
                values: new object[,]
                {
                    { 1, 3, 2, 2, new DateTime(2025, 9, 28, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(5300), "Find two numbers in an array that add up to a target sum and return their indices.", "Easy", true, true, "Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.", "nums = [2,7,11,15], target = 9", "[0,1]", "Use a hash map to store complements and their indices for O(n) solution.", "hash map, two pointers", "Two Sum", "Arrays", 2023 },
                    { 2, 1, 1, 2, new DateTime(2025, 10, 1, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(5666), "Reverse the direction of pointers in a singly linked list.", "Medium", true, true, "Given the head of a singly linked list, reverse the list, and return the reversed list.", "head = [1,2,3,4,5]", "[5,4,3,2,1]", "Use iterative approach with three pointers: prev, current, and next.", "linked list, pointers", "Reverse Linked List", "Linked Lists", 2024 }
                });

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 22, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 22, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 24, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 26, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 27, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 28, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 30, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 1, 20, 16, 40, 150, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.InsertData(
                table: "MCQs",
                columns: new[] { "Id", "CollegeId", "CompanyId", "ContributorId", "CorrectAnswer", "CreatedDate", "Difficulty", "Explanation", "IsActive", "IsApproved", "OptionA", "OptionB", "OptionC", "OptionD", "Question", "Tags", "Topic", "Year" },
                values: new object[,]
                {
                    { 3, 1, 1, 2, "A", new DateTime(2025, 9, 30, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(1788), "Easy", "SQL stands for Structured Query Language, used for managing relational databases.", true, true, "Structured Query Language", "Simple Query Language", "Sequential Query Language", "Standard Query Language", "What does SQL stand for?", "SQL, database", "Database", 2024 },
                    { 2, 3, 2, 2, "B", new DateTime(2025, 9, 29, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(1774), "Easy", "Stack follows Last In First Out (LIFO) principle where the last element added is the first one to be removed.", true, true, "Queue", "Stack", "Array", "Linked List", "Which data structure uses LIFO principle?", "stack, LIFO", "Data Structures", 2023 },
                    { 1, 3, 2, 2, "B", new DateTime(2025, 9, 27, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(1252), "Medium", "Binary search divides the search space in half with each comparison, resulting in O(log n) time complexity.", true, true, "O(n)", "O(log n)", "O(n^2)", "O(1)", "What is the time complexity of binary search?", "binary search, time complexity", "Algorithms", 2023 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 148, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 148, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 16, 40, 148, DateTimeKind.Local).AddTicks(6570));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodingQuestions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CodingQuestions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MCQs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MCQs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MCQs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 22, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 22, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 24, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 26, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 27, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 28, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 30, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 1, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 341, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 341, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 35, 32, 341, DateTimeKind.Local).AddTicks(8659));
        }
    }
}
