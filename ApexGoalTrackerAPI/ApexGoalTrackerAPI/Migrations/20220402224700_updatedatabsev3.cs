using Microsoft.EntityFrameworkCore.Migrations;

namespace ApexGoalTrackerAPI.Migrations
{
    public partial class updatedatabsev3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_currentStats_Users_ApexID",
                table: "currentStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_currentStats",
                table: "currentStats");

            migrationBuilder.AlterColumn<string>(
                name: "ApexID",
                table: "currentStats",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "currentStats",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "currentStats",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_currentStats",
                table: "currentStats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_currentStats_UserName",
                table: "currentStats",
                column: "UserName");

            migrationBuilder.AddForeignKey(
                name: "FK_currentStats_Users_UserName",
                table: "currentStats",
                column: "UserName",
                principalTable: "Users",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_currentStats_Users_UserName",
                table: "currentStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_currentStats",
                table: "currentStats");

            migrationBuilder.DropIndex(
                name: "IX_currentStats_UserName",
                table: "currentStats");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "currentStats");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "currentStats");

            migrationBuilder.AlterColumn<string>(
                name: "ApexID",
                table: "currentStats",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_currentStats",
                table: "currentStats",
                column: "ApexID");

            migrationBuilder.AddForeignKey(
                name: "FK_currentStats_Users_ApexID",
                table: "currentStats",
                column: "ApexID",
                principalTable: "Users",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
