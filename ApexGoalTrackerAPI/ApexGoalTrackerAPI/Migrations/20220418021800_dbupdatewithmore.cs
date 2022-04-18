using Microsoft.EntityFrameworkCore.Migrations;

namespace ApexGoalTrackerAPI.Migrations
{
    public partial class dbupdatewithmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApexLevel",
                table: "currentStats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextLevelPercent",
                table: "currentStats",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RankDiv",
                table: "currentStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RankImg",
                table: "currentStats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RankedSeason",
                table: "currentStats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SelectedLegend",
                table: "currentStats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "icon",
                table: "currentStats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApexLevel",
                table: "currentStats");

            migrationBuilder.DropColumn(
                name: "NextLevelPercent",
                table: "currentStats");

            migrationBuilder.DropColumn(
                name: "RankDiv",
                table: "currentStats");

            migrationBuilder.DropColumn(
                name: "RankImg",
                table: "currentStats");

            migrationBuilder.DropColumn(
                name: "RankedSeason",
                table: "currentStats");

            migrationBuilder.DropColumn(
                name: "SelectedLegend",
                table: "currentStats");

            migrationBuilder.DropColumn(
                name: "icon",
                table: "currentStats");
        }
    }
}
