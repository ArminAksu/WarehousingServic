using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehousingServic.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loginFieldRequests_jwtFeilds_JwtFeildstoken",
                table: "loginFieldRequests");

            migrationBuilder.DropIndex(
                name: "IX_loginFieldRequests_JwtFeildstoken",
                table: "loginFieldRequests");

            migrationBuilder.DropColumn(
                name: "JwtFeildstoken",
                table: "loginFieldRequests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JwtFeildstoken",
                table: "loginFieldRequests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_loginFieldRequests_JwtFeildstoken",
                table: "loginFieldRequests",
                column: "JwtFeildstoken");

            migrationBuilder.AddForeignKey(
                name: "FK_loginFieldRequests_jwtFeilds_JwtFeildstoken",
                table: "loginFieldRequests",
                column: "JwtFeildstoken",
                principalTable: "jwtFeilds",
                principalColumn: "token");
        }
    }
}
