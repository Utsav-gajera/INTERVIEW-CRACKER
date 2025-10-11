using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewCracker.Migrations
{
    public partial class UpdateCompanyCollegeAssignments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 22, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CollegeId", "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { 2, new DateTime(2025, 9, 14, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6038), "IT Services and Consulting", "/images/tcs.jpg", "TCS", "https://tcs.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CollegeId", "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { 3, new DateTime(2025, 9, 17, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6041), "Consumer electronics company", "/images/apple.jpg", "Apple", "https://apple.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CollegeId", "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { 3, new DateTime(2025, 9, 22, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6045), "Social media and technology", "/images/meta.jpg", "Meta", "https://meta.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CollegeId", "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { 4, new DateTime(2025, 9, 20, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6048), "Investment banking and financial services", "/images/goldman.jpg", "Goldman Sachs", "https://goldmansachs.com" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CollegeId", "CreatedDate", "Description", "IsActive", "LogoUrl", "Name", "Website" },
                values: new object[,]
                {
                    { 12, 0, new DateTime(2025, 10, 1, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6065), "Professional services company", true, "/images/accenture.jpg", "Accenture", "https://accenture.com" },
                    { 11, 0, new DateTime(2025, 9, 30, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6062), "Technology and consulting services", true, "/images/ibm.jpg", "IBM", "https://ibm.com" },
                    { 10, 5, new DateTime(2025, 9, 28, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6058), "IT Services and Consulting", true, "/images/wipro.jpg", "Wipro", "https://wipro.com" },
                    { 9, 5, new DateTime(2025, 9, 26, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6055), "IT Services and Digital transformation", true, "/images/infosys.jpg", "Infosys", "https://infosys.com" },
                    { 8, 4, new DateTime(2025, 9, 24, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6051), "Semiconductor and technology", true, "/images/intel.jpg", "Intel", "https://intel.com" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 8, 0, 497, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 8, 0, 497, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 8, 0, 497, DateTimeKind.Local).AddTicks(7690));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 22, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CollegeId", "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { 4, new DateTime(2025, 9, 17, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3780), "Consumer electronics company", "/images/apple.jpg", "Apple", "https://apple.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CollegeId", "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { 5, new DateTime(2025, 9, 22, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3783), "Social media and technology", "/images/meta.jpg", "Meta", "https://meta.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CollegeId", "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { 0, new DateTime(2025, 9, 2, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3786), "IT Services and Consulting", "/images/tcs.jpg", "TCS", "https://tcs.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CollegeId", "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { 0, new DateTime(2025, 9, 7, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3790), "IT Services Company", "/images/infosys.jpg", "Infosys", "https://infosys.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 4, 45, 956, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 4, 45, 956, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 18, 4, 45, 956, DateTimeKind.Local).AddTicks(7518));
        }
    }
}
