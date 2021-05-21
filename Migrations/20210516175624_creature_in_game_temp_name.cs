using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDIniativeTracker.Migrations
{
    public partial class creature_in_game_temp_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TempName",
                table: "CreaturesInGames",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempName",
                table: "CreaturesInGames");
        }
    }
}
