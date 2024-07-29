using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class sana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_Statuses_StatusId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_subCategories_subCategoryId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_CategoryId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_StatusId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_subCategoryId",
                table: "product");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "brands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_CategoryId",
                table: "product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_product_StatusId",
                table: "product",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_product_subCategoryId",
                table: "product",
                column: "subCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product",
                column: "CategoryId",
                principalTable: "category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_Statuses_StatusId",
                table: "product",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_subCategories_subCategoryId",
                table: "product",
                column: "subCategoryId",
                principalTable: "subCategories",
                principalColumn: "subCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
