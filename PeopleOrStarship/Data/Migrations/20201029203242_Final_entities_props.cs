using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleOrStarship.Migrations
{
    public partial class Final_entities_props : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Mass = table.Column<int>(type: "int", nullable: false),
                    HairColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EyeColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WinCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostInCredits = table.Column<long>(type: "bigint", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    MaxAtmospheringSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crew = table.Column<int>(type: "int", nullable: false),
                    Passengers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoCapacity = table.Column<long>(type: "bigint", nullable: false),
                    Consumables = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HyperdriveRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StarshipClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WinCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Starships");
        }
    }
}
