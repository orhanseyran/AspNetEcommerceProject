using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMvcAuthApp.Migrations
{
    /// <inheritdoc />
    public partial class yeni49 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Create_At",
                table: "WishLists",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Update_At",
                table: "WishLists",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Create_At",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "Update_At",
                table: "WishLists");
        }
    }
}
