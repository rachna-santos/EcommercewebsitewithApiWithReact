using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_AspNetUsers_UserId",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_brands_BrandId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_category_categoryId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_colors_ColoId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_product_productId",
                table: "productveriations");

            migrationBuilder.DropForeignKey(
                name: "FK_productveriations_Statuses_StatusId",
                table: "productveriations");

            migrationBuilder.DropTable(
                name: "cart_Items");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_BrandId",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_categoryId",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_ColoId",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_productId",
                table: "productveriations");

            migrationBuilder.DropIndex(
                name: "IX_productveriations_StatusId",
                table: "productveriations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carts",
                table: "carts");

            migrationBuilder.RenameTable(
                name: "carts",
                newName: "Cart");

            migrationBuilder.RenameIndex(
                name: "IX_carts_UserId",
                table: "Cart",
                newName: "IX_Cart_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_AspNetUsers_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_AspNetUsers_UserId",
                table: "Cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "carts");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_UserId",
                table: "carts",
                newName: "IX_carts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carts",
                table: "carts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "cart_Items",
                columns: table => new
                {
                    cart_item = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart_Items", x => x.cart_item);
                    table.ForeignKey(
                        name: "FK_cart_Items_product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_BrandId",
                table: "productveriations",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_categoryId",
                table: "productveriations",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_ColoId",
                table: "productveriations",
                column: "ColoId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_productId",
                table: "productveriations",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_StatusId",
                table: "productveriations",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_cart_Items_ProductId",
                table: "cart_Items",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_AspNetUsers_UserId",
                table: "carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_brands_BrandId",
                table: "productveriations",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_category_categoryId",
                table: "productveriations",
                column: "categoryId",
                principalTable: "category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_colors_ColoId",
                table: "productveriations",
                column: "ColoId",
                principalTable: "colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_product_productId",
                table: "productveriations",
                column: "productId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productveriations_Statuses_StatusId",
                table: "productveriations",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
