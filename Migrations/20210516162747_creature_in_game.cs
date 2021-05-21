using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDIniativeTracker.Migrations
{
    public partial class creature_in_game : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Creatures_Games_GameId",
                table: "Creatures");

            migrationBuilder.DropIndex(
                name: "IX_Creatures_GameId",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Creatures");

            migrationBuilder.CreateTable(
                name: "CreaturesInGames",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreaturesInGames", x => new { x.CreatureId, x.GameId });
                    table.ForeignKey(
                        name: "FK_CreaturesInGames_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CreaturesInGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreaturesInGames_GameId",
                table: "CreaturesInGames",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreaturesInGames");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Creatures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_GameId",
                table: "Creatures",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Creatures_Games_GameId",
                table: "Creatures",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
