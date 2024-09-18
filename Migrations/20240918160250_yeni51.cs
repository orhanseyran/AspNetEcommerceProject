using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMvcAuthApp.Migrations
{
    /// <inheritdoc />
    public partial class yeni51 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComporeId",
                table: "Images",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Compores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    stock = table.Column<double>(type: "REAL", nullable: true),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    ShipDetail = table.Column<string>(type: "TEXT", nullable: true),
                    CargoDesi = table.Column<double>(type: "REAL", nullable: true),
                    Cargo = table.Column<string>(type: "TEXT", nullable: true),
                    Sehir = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Create_At = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Update_At = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compores", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ComporeId",
                table: "Images",
                column: "ComporeId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Compores_ComporeId",
                table: "Images",
                column: "ComporeId",
                principalTable: "Compores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Compores_ComporeId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Compores");

            migrationBuilder.DropIndex(
                name: "IX_Images_ComporeId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProductId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ComporeId",
                table: "Images");
        }
    }
}
