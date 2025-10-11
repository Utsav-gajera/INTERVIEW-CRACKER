using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewCracker.Migrations
{
    public partial class CreateManyToManyCollegeCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "Companies");

            migrationBuilder.CreateTable(
                name: "CollegeCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CollegeId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollegeCompanies_Colleges_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "Colleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeCompanies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CollegeCompanies",
                columns: new[] { "Id", "CollegeId", "CompanyId", "CreatedDate", "IsActive" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9000), true },
                    { 25, 5, 12, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9318), true },
                    { 24, 5, 10, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9315), true },
                    { 22, 5, 8, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9309), true },
                    { 21, 5, 2, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9306), true },
                    { 20, 4, 12, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9304), true },
                    { 19, 4, 11, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9301), true },
                    { 18, 4, 3, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9298), true },
                    { 17, 4, 2, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9295), true },
                    { 16, 4, 1, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9292), true },
                    { 15, 3, 7, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9289), true },
                    { 14, 3, 6, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9286), true },
                    { 23, 5, 9, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9312), true },
                    { 12, 3, 4, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9281), true },
                    { 11, 3, 2, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9278), true },
                    { 10, 2, 12, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9275), true },
                    { 9, 2, 9, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9272), true },
                    { 8, 2, 8, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9269), true },
                    { 7, 2, 3, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9266), true },
                    { 6, 2, 2, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9263), true },
                    { 5, 1, 12, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9260), true },
                    { 4, 1, 4, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9257), true },
                    { 3, 1, 3, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9254), true },
                    { 2, 1, 2, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9246), true },
                    { 13, 3, 5, new DateTime(2025, 10, 2, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(9284), true }
                });

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
                columns: new[] { "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { new DateTime(2025, 9, 17, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7525), "Consumer electronics company", "/images/apple.jpg", "Apple", "https://apple.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { new DateTime(2025, 9, 22, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7530), "Social media and technology", "/images/meta.jpg", "Meta", "https://meta.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { new DateTime(2025, 9, 24, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7534), "Electric vehicles and clean energy", "/images/tesla.jpg", "Tesla", "https://tesla.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { new DateTime(2025, 9, 26, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7537), "Streaming entertainment service", "/images/netflix.jpg", "Netflix", "https://netflix.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { new DateTime(2025, 9, 27, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7540), "IT Services and Consulting", "/images/tcs.jpg", "TCS", "https://tcs.com" });

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
                columns: new[] { "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { new DateTime(2025, 9, 30, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7551), "Investment banking and financial services", "/images/goldman.jpg", "Goldman Sachs", "https://goldmansachs.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { new DateTime(2025, 10, 1, 18, 35, 32, 343, DateTimeKind.Local).AddTicks(7554), "Technology and consulting services", "/images/ibm.jpg", "IBM", "https://ibm.com" });

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

            migrationBuilder.CreateIndex(
                name: "IX_CollegeCompanies_CompanyId",
                table: "CollegeCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeCompanies_CollegeId_CompanyId",
                table: "CollegeCompanies",
                columns: new[] { "CollegeId", "CompanyId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeCompanies");

            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2025, 9, 2, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2025, 9, 7, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2025, 9, 12, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6034) });

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

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CollegeId", "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { 4, new DateTime(2025, 9, 24, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6051), "Semiconductor and technology", "/images/intel.jpg", "Intel", "https://intel.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2025, 9, 26, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CollegeId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2025, 9, 28, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { new DateTime(2025, 9, 30, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6062), "Technology and consulting services", "/images/ibm.jpg", "IBM", "https://ibm.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "LogoUrl", "Name", "Website" },
                values: new object[] { new DateTime(2025, 10, 1, 18, 8, 0, 499, DateTimeKind.Local).AddTicks(6065), "Professional services company", "/images/accenture.jpg", "Accenture", "https://accenture.com" });

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
    }
}
