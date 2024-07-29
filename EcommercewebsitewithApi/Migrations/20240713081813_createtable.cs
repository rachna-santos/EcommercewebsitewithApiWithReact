using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class createtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_colors_ColorId",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_ColorId",
                table: "productveriations");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "productveriations");

            migrationBuilder.RenameColumn(
                name: "productgenderId",
                table: "productveriations",
                newName: "productseasonId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_Id",
                table: "productveriations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_productseasonId",
                table: "productveriations",
                column: "productseasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_colors_Id",
                table: "productveriations",
                column: "Id",
                principalTable: "colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_productSeasons_productseasonId",
                table: "productveriations",
                column: "productseasonId",
                principalTable: "productSeasons",
                principalColumn: "productseasonId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_colors_Id",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_productSeasons_productseasonId",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_Id",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_productseasonId",
                table: "productveriations");

            migrationBuilder.RenameColumn(
                name: "productseasonId",
                table: "productveriations",
                newName: "productgenderId");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "productveriations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_ColorId",
                table: "productveriations",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_colors_ColorId",
                table: "productveriations",
                column: "ColorId",
                principalTable: "colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
