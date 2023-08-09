using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehousingServic.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jwtFeilds",
                columns: table => new
                {
                    token = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expire_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jwtFeilds", x => x.token);
                });

            migrationBuilder.CreateTable(
                name: "loginFieldRequests",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loginFieldRequests", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "productFeatures",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductGroupId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Price = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    ExpirationData = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productFeatures", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfReceipt = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    ProductId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    NumberOfProduct = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    PriceOfProduct = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    TotalPrice = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    InventoryIncrease = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RemittanceFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfRemittance = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    ProductId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    PriceProduct = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    InventoryReduction = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemittanceFeatures", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParentGroupe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductGroupCode = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    ProductGroupId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductGroups_productFeatures_Price",
                        column: x => x.Price,
                        principalTable: "productFeatures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductGroups_ReceiptFeatures_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ReceiptFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductGroups_RemittanceFeatures_ProductId",
                        column: x => x.ProductId,
                        principalTable: "RemittanceFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JwtFeildsLoginFieldRequest_LoginFieldRequestsUserName",
                table: "JwtFeildsLoginFieldRequest",
                column: "LoginFieldRequestsUserName");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_Price",
                table: "ProductGroups",
                column: "Price");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ProductGroupId",
                table: "ProductGroups",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ProductId",
                table: "ProductGroups",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JwtFeildsLoginFieldRequest");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "jwtFeilds");

            migrationBuilder.DropTable(
                name: "loginFieldRequests");

            migrationBuilder.DropTable(
                name: "productFeatures");

            migrationBuilder.DropTable(
                name: "ReceiptFeatures");

            migrationBuilder.DropTable(
                name: "RemittanceFeatures");
        }
    }
}
