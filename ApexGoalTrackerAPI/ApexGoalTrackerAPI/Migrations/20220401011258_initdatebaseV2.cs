using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApexGoalTrackerAPI.Migrations
{
    public partial class initdatebaseV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    ApexID = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "currentStats",
                columns: table => new
                {
                    ApexID = table.Column<string>(nullable: false),
                    RankSore = table.Column<int>(nullable: false),
                    RankName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    banner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currentStats", x => x.ApexID);
                    table.ForeignKey(
                        name: "FK_currentStats_Users_ApexID",
                        column: x => x.ApexID,
                        principalTable: "Users",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userGoals",
                columns: table => new
                {
                    ApexID = table.Column<string>(nullable: false),
                    RankScore = table.Column<int>(nullable: false),
                    RankName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userGoals", x => x.ApexID);
                    table.ForeignKey(
                        name: "FK_userGoals_Users_ApexID",
                        column: x => x.ApexID,
                        principalTable: "Users",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "currentStats");

            migrationBuilder.DropTable(
                name: "userGoals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
