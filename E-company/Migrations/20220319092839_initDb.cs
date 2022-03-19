using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_company.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true),
                    MinimumSalary = table.Column<double>(nullable: false),
                    MaximumSalary = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Department_Id = table.Column<int>(nullable: false),
                    Country_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_employees_countries_Country_ID",
                        column: x => x.Country_ID,
                        principalTable: "countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_departments_Department_Id",
                        column: x => x.Department_Id,
                        principalTable: "departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_Country_ID",
                table: "employees",
                column: "Country_ID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Department_Id",
                table: "employees",
                column: "Department_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
