using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDIniativeTracker.Migrations
{
    public partial class creature_in_game_hp_and_initaitive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Initiav",
                table: "Creatures",
                newName: "Initiative");

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "CreaturesInGames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Initiative",
                table: "CreaturesInGames",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HP",
                table: "CreaturesInGames");

            migrationBuilder.DropColumn(
                name: "Initiative",
                table: "CreaturesInGames");

            migrationBuilder.RenameColumn(
                name: "Initiative",
                table: "Creatures",
                newName: "Initiav");
        }
    }
}
