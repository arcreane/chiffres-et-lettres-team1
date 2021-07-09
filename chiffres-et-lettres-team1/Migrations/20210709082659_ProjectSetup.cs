using Microsoft.EntityFrameworkCore.Migrations;

namespace chiffres_et_lettres_team1.Migrations
{
    public partial class ProjectSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameID);
                    table.ForeignKey(
                        name: "FK_Game_Game_GameID1",
                        column: x => x.GameID1,
                        principalTable: "Game",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Letters",
                columns: table => new
                {
                    LettersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LettersID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Letters", x => x.LettersID);
                    table.ForeignKey(
                        name: "FK_Letters_Letters_LettersID1",
                        column: x => x.LettersID1,
                        principalTable: "Letters",
                        principalColumn: "LettersID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Numbers",
                columns: table => new
                {
                    NumbersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    NumbersID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numbers", x => x.NumbersID);
                    table.ForeignKey(
                        name: "FK_Numbers_Numbers_NumbersID1",
                        column: x => x.NumbersID1,
                        principalTable: "Numbers",
                        principalColumn: "NumbersID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PlayerID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerID);
                    table.ForeignKey(
                        name: "FK_Player_Player_PlayerID1",
                        column: x => x.PlayerID1,
                        principalTable: "Player",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_GameID1",
                table: "Game",
                column: "GameID1");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_LettersID1",
                table: "Letters",
                column: "LettersID1");

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_NumbersID1",
                table: "Numbers",
                column: "NumbersID1");

            migrationBuilder.CreateIndex(
                name: "IX_Player_PlayerID1",
                table: "Player",
                column: "PlayerID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Letters");

            migrationBuilder.DropTable(
                name: "Numbers");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
