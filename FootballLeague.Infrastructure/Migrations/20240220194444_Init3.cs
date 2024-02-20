using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Statistics_NumberOfDefeats",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Statistics_NumberOfDraws",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Statistics_NumberOfMatches",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Statistics_NumberOfWins",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Statistics_TotalPoints",
                table: "Teams");

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    NumberOfMatches = table.Column<int>(type: "int", nullable: false),
                    TotalPoints = table.Column<int>(type: "int", nullable: false),
                    NumberOfWins = table.Column<int>(type: "int", nullable: false),
                    NumberOfDraws = table.Column<int>(type: "int", nullable: false),
                    NumberOfDefeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Statistics_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndYear", "StartYear" },
                values: new object[] { 1, 2023, 2022 });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Name", "SeasonId" },
                values: new object[] { 1, "Jupiler League", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Statistics_NumberOfDefeats",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Statistics_NumberOfDraws",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Statistics_NumberOfMatches",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Statistics_NumberOfWins",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Statistics_TotalPoints",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
