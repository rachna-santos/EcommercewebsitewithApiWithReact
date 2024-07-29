using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class hamad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "genderName",
                table: "materials",
                newName: "MaterialName");

            migrationBuilder.RenameColumn(
                name: "genderId",
                table: "materials",
                newName: "MaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaterialName",
                table: "materials",
                newName: "genderName");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "materials",
                newName: "genderId");
        }
    }
}
