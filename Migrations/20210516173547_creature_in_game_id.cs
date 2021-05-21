using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDIniativeTracker.Migrations
{
    public partial class creature_in_game_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CreaturesInGames",
                table: "CreaturesInGames");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CreaturesInGames",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreaturesInGames",
                table: "CreaturesInGames",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CreaturesInGames_CreatureId",
                table: "CreaturesInGames",
                column: "CreatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CreaturesInGames",
                table: "CreaturesInGames");

            migrationBuilder.DropIndex(
                name: "IX_CreaturesInGames_CreatureId",
                table: "CreaturesInGames");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CreaturesInGames");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreaturesInGames",
                table: "CreaturesInGames",
                columns: new[] { "CreatureId", "GameId" });
        }
    }
}
