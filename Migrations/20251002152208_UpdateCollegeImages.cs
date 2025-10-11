using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewCracker.Migrations
{
    public partial class UpdateCollegeImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Update college image URLs to match actual image files
            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/colleges/MIT College of Engineering.jpg");

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/colleges/COEP Technological University.jpg");

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/colleges/VIT Vellore.jpg");

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/colleges/IIT Bombay.webp");

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/colleges/NIT Trichy.jpg");
            migrationBuilder.UpdateData(
                table: "CodingQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 28, 20, 52, 7, 515, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "CodingQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 1, 20, 52, 7, 515, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "CollegeCompanies",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 22, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 22, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 24, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 26, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 27, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 28, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 30, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 1, 20, 52, 7, 514, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "MCQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 27, 20, 52, 7, 515, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "MCQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 20, 52, 7, 515, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "MCQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 30, 20, 52, 7, 515, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 513, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 513, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 20, 52, 7, 513, DateTimeKind.Local).AddTicks(2173));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CodingQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 28, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "CodingQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 1, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(5666));

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

            migrationBuilder.UpdateData(
                table: "MCQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 27, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "MCQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "MCQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 30, 20, 16, 40, 151, DateTimeKind.Local).AddTicks(1788));

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
    }
}
