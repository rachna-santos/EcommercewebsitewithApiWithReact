using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class sir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_brands_Statuses_StatusId",
                table: "brands");

            migrationBuilder.DropIndex(
                name: "IX_brands_StatusId",
                table: "brands");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_brands_StatusId",
                table: "brands",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_brands_Statuses_StatusId",
                table: "brands",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
