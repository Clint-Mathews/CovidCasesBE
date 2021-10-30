using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidCases.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CovidData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iso_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    continent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_cases = table.Column<int>(type: "int", nullable: false),
                    new_cases = table.Column<int>(type: "int", nullable: false),
                    total_deaths = table.Column<int>(type: "int", nullable: false),
                    new_deaths = table.Column<int>(type: "int", nullable: false),
                    hosp_patients = table.Column<int>(type: "int", nullable: false),
                    positive_rate = table.Column<int>(type: "int", nullable: false),
                    people_vaccinated = table.Column<int>(type: "int", nullable: false),
                    people_fully_vaccinated = table.Column<int>(type: "int", nullable: false),
                    new_vaccinations = table.Column<int>(type: "int", nullable: false),
                    people_fully_vaccinated_per_hundred = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CovidData");
        }
    }
}
