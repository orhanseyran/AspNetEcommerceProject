using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMvcAuthApp.Migrations
{
    /// <inheritdoc />
    public partial class yeni59 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Jwt",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Jwt",
                table: "AspNetUsers");
        }
    }
}
