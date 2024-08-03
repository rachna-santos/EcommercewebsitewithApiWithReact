using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class newtablegenerate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_categoryStyles_categorystyleid",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_genders_genderId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_materials_MaterialId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_productSeasons_productseasonId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_sizes_SizeId",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_categorystyleid",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_genderId",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_MaterialId",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_SizeId",
                table: "productveriations");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "productveriations");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "productveriations");

            migrationBuilder.DropColumn(
                name: "categorystyleid",
                table: "productveriations");

            migrationBuilder.DropColumn(
                name: "genderId",
                table: "productveriations");

            migrationBuilder.RenameColumn(
                name: "productseasonId",
                table: "productveriations",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_productveriations_productseasonId",
                table: "productveriations",
                newName: "IX_productveriations_BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_brands_BrandId",
                table: "productveriations",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_brands_BrandId",
                table: "productveriations");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "productveriations",
                newName: "productseasonId");

            migrationBuilder.RenameIndex(
                name: "IX_productveriations_BrandId",
                table: "productveriations",
                newName: "IX_productveriations_productseasonId");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "productveriations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "productveriations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "categorystyleid",
                table: "productveriations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "genderId",
                table: "productveriations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_categorystyleid",
                table: "productveriations",
                column: "categorystyleid");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_genderId",
                table: "productveriations",
                column: "genderId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_MaterialId",
                table: "productveriations",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_SizeId",
                table: "productveriations",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_categoryStyles_categorystyleid",
                table: "productveriations",
                column: "categorystyleid",
                principalTable: "categoryStyles",
                principalColumn: "categorystyleid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_genders_genderId",
                table: "productveriations",
                column: "genderId",
                principalTable: "genders",
                principalColumn: "genderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_materials_MaterialId",
                table: "productveriations",
                column: "MaterialId",
                principalTable: "materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_productSeasons_productseasonId",
                table: "productveriations",
                column: "productseasonId",
                principalTable: "productSeasons",
                principalColumn: "productseasonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_sizes_SizeId",
                table: "productveriations",
                column: "SizeId",
                principalTable: "sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
