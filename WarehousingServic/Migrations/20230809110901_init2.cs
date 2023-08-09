using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehousingServic.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JwtFeildsLoginFieldRequest");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "JwtFeildsLoginFieldRequest",
                columns: table => new
                {
                    JwtFeildstoken = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginFieldRequestsUserName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JwtFeildsLoginFieldRequest", x => new { x.JwtFeildstoken, x.LoginFieldRequestsUserName });
                    table.ForeignKey(
                        name: "FK_JwtFeildsLoginFieldRequest_jwtFeilds_JwtFeildstoken",
                        column: x => x.JwtFeildstoken,
                        principalTable: "jwtFeilds",
                        principalColumn: "token",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JwtFeildsLoginFieldRequest_loginFieldRequests_LoginFieldRequestsUserName",
                        column: x => x.LoginFieldRequestsUserName,
                        principalTable: "loginFieldRequests",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JwtFeildsLoginFieldRequest_LoginFieldRequestsUserName",
                table: "JwtFeildsLoginFieldRequest",
                column: "LoginFieldRequestsUserName");
        }
    }
}
