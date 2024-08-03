using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class addveraitiontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_brands_BrandId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_category_categoryId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_colors_Id",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_product_productId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_Statuses_StatusId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_subCategories_subcategoryId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_shoppingCarts_productveriations_veriationId",
                table: "shoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productveriations",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_Id",
                table: "productveriations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "productveriations");

            migrationBuilder.RenameTable(
                name: "productveriations",
                newName: "Productveriation");

            migrationBuilder.RenameColumn(
                name: "subcategoryId",
                table: "Productveriation",
                newName: "ColoId");

            migrationBuilder.RenameIndex(
                name: "IX_productveriations_subcategoryId",
                table: "Productveriation",
                newName: "IX_Productveriation_ColoId");

            migrationBuilder.RenameIndex(
                name: "IX_productveriations_StatusId",
                table: "Productveriation",
                newName: "IX_Productveriation_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_productveriations_productId",
                table: "Productveriation",
                newName: "IX_Productveriation_productId");

            migrationBuilder.RenameIndex(
                name: "IX_productveriations_categoryId",
                table: "Productveriation",
                newName: "IX_Productveriation_categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_productveriations_BrandId",
                table: "Productveriation",
                newName: "IX_Productveriation_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productveriation",
                table: "Productveriation",
                column: "veriationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productveriation_brands_BrandId",
                table: "Productveriation",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Productveriation_category_categoryId",
                table: "Productveriation",
                column: "categoryId",
                principalTable: "category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Productveriation_colors_ColoId",
                table: "Productveriation",
                column: "ColoId",
                principalTable: "colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Productveriation_product_productId",
                table: "Productveriation",
                column: "productId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Productveriation_Statuses_StatusId",
                table: "Productveriation",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_shoppingCarts_Productveriation_veriationId",
                table: "shoppingCarts",
                column: "veriationId",
                principalTable: "Productveriation",
                principalColumn: "veriationId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productveriation_brands_BrandId",
                table: "Productveriation");

            migrationBuilder.DropForeignKey(
                name: "FK_Productveriation_category_categoryId",
                table: "Productveriation");

            migrationBuilder.DropForeignKey(
                name: "FK_Productveriation_colors_ColoId",
                table: "Productveriation");

            migrationBuilder.DropForeignKey(
                name: "FK_Productveriation_product_productId",
                table: "Productveriation");

            migrationBuilder.DropForeignKey(
                name: "FK_Productveriation_Statuses_StatusId",
                table: "Productveriation");

            migrationBuilder.DropForeignKey(
                name: "FK_shoppingCarts_Productveriation_veriationId",
                table: "shoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productveriation",
                table: "Productveriation");

            migrationBuilder.RenameTable(
                name: "Productveriation",
                newName: "productveriations");

            migrationBuilder.RenameColumn(
                name: "ColoId",
                table: "productveriations",
                newName: "subcategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Productveriation_StatusId",
                table: "productveriations",
                newName: "IX_productveriations_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Productveriation_productId",
                table: "productveriations",
                newName: "IX_productveriations_productId");

            migrationBuilder.RenameIndex(
                name: "IX_Productveriation_ColoId",
                table: "productveriations",
                newName: "IX_productveriations_subcategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Productveriation_categoryId",
                table: "productveriations",
                newName: "IX_productveriations_categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Productveriation_BrandId",
                table: "productveriations",
                newName: "IX_productveriations_BrandId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "productveriations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_productveriations",
                table: "productveriations",
                column: "veriationId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_Id",
                table: "productveriations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_brands_BrandId",
                table: "productveriations",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_category_categoryId",
                table: "productveriations",
                column: "categoryId",
                principalTable: "category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_colors_Id",
                table: "productveriations",
                column: "Id",
                principalTable: "colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_product_productId",
                table: "productveriations",
                column: "productId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_Statuses_StatusId",
                table: "productveriations",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_subCategories_subcategoryId",
                table: "productveriations",
                column: "subcategoryId",
                principalTable: "subCategories",
                principalColumn: "subCategoryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_shoppingCarts_productveriations_veriationId",
                table: "shoppingCarts",
                column: "veriationId",
                principalTable: "productveriations",
                principalColumn: "veriationId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
