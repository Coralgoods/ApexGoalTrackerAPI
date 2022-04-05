using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApexGoalTrackerAPI.Migrations
{
    public partial class doodad : Migration
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApexID = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    RankSore = table.Column<int>(nullable: false),
                    RankName = table.Column<string>(nullable: true),
                    banner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currentStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_currentStats_Users_UserName",
                        column: x => x.UserName,
                        principalTable: "Users",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_currentStats_UserName",
                table: "currentStats",
                column: "UserName");
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
