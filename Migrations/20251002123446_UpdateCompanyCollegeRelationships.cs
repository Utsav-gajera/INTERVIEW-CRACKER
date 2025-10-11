using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewCracker.Migrations
{
    public partial class UpdateCompanyCollegeRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2025, 9, 2, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2025, 9, 7, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2025, 9, 12, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 4, new DateTime(2025, 9, 17, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2025, 9, 22, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CollegeId", "CreatedDate", "Description", "IsActive", "LogoUrl", "Name", "Website" },
                values: new object[,]
                {
                    { 6, 0, new DateTime(2025, 9, 2, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3786), "IT Services and Consulting", true, "/images/tcs.jpg", "TCS", "https://tcs.com" },
                    { 7, 0, new DateTime(2025, 9, 7, 18, 4, 45, 958, DateTimeKind.Local).AddTicks(3790), "IT Services Company", true, "/images/infosys.jpg", "Infosys", "https://infosys.com" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 2, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 7, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 12, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 17, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 22, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 0, new DateTime(2025, 9, 2, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 0, new DateTime(2025, 9, 7, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 0, new DateTime(2025, 9, 12, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 0, new DateTime(2025, 9, 17, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 0, new DateTime(2025, 9, 22, 17, 28, 55, 233, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 17, 28, 55, 231, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 17, 28, 55, 231, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 10, 2, 17, 28, 55, 231, DateTimeKind.Local).AddTicks(9103));
        }
    }
}
