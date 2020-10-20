using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleOrStarship.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CrewCount",
                table: "Starships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MassCount",
                table: "Peoples",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrewCount",
                table: "Starships");

            migrationBuilder.DropColumn(
                name: "MassCount",
                table: "Peoples");
        }
    }
}
