using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMvcAuthApp.Migrations
{
    /// <inheritdoc />
    public partial class Migrate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Carts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Carts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Carts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserAddress",
                table: "Carts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Carts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Carts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserPhone",
                table: "Carts",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UserAddress",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UserPhone",
                table: "Carts");
        }
    }
}
