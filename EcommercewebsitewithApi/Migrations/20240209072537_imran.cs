using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class imran : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_AspNetUsers_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_register_UserId1",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Statuses_StatusId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "order");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "carts");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId1",
                table: "order",
                newName: "IX_order_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "order",
                newName: "IX_order_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_StatusId",
                table: "order",
                newName: "IX_order_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_UserId",
                table: "carts",
                newName: "IX_carts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order",
                table: "order",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carts",
                table: "carts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.BrandId);
                    table.ForeignKey(
                        name: "FK_brands_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    colorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    colorcode1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    colorcode2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_colors_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "materials",
                columns: table => new
                {
                    genderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materials", x => x.genderId);
                    table.ForeignKey(
                        name: "FK_materials_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sizes_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "subCategories",
                columns: table => new
                {
                    subCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subCategories", x => x.subCategoryId);
                    table.ForeignKey(
                        name: "FK_subCategories_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subCategoryId = table.Column<int>(type: "int", nullable: false),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_category_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_category_subCategories_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "subCategories",
                        principalColumn: "subCategoryId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subCategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_product_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_product_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_product_subCategories_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "subCategories",
                        principalColumn: "subCategoryId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "cart_Items",
                columns: table => new
                {
                    cart_item = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart_Items", x => x.cart_item);
                    table.ForeignKey(
                        name: "FK_cart_Items_product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "order_Details",
                columns: table => new
                {
                    order_details = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    order_id1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_Details", x => x.order_details);
                    table.ForeignKey(
                        name: "FK_order_Details_order_order_id1",
                        column: x => x.order_id1,
                        principalTable: "order",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_order_Details_product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_brands_StatusId",
                table: "brands",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_cart_Items_ProductId",
                table: "cart_Items",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_category_StatusId",
                table: "category",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_category_subCategoryId",
                table: "category",
                column: "subCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_colors_StatusId",
                table: "colors",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_materials_StatusId",
                table: "materials",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_order_Details_order_id1",
                table: "order_Details",
                column: "order_id1");

            migrationBuilder.CreateIndex(
                name: "IX_order_Details_ProductId",
                table: "order_Details",
                column: "ProductId");

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

            migrationBuilder.CreateIndex(
                name: "IX_sizes_StatusId",
                table: "sizes",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_subCategories_StatusId",
                table: "subCategories",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_AspNetUsers_UserId",
                table: "carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_AspNetUsers_UserId",
                table: "order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_register_UserId1",
                table: "order",
                column: "UserId1",
                principalTable: "register",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_order_Statuses_StatusId",
                table: "order",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_AspNetUsers_UserId",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_order_AspNetUsers_UserId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_register_UserId1",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_Statuses_StatusId",
                table: "order");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "cart_Items");

            migrationBuilder.DropTable(
                name: "colors");

            migrationBuilder.DropTable(
                name: "materials");

            migrationBuilder.DropTable(
                name: "order_Details");

            migrationBuilder.DropTable(
                name: "sizes");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "subCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carts",
                table: "carts");

            migrationBuilder.RenameTable(
                name: "order",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "carts",
                newName: "Cart");

            migrationBuilder.RenameIndex(
                name: "IX_order_UserId1",
                table: "Order",
                newName: "IX_Order_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_order_UserId",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_order_StatusId",
                table: "Order",
                newName: "IX_Order_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_carts_UserId",
                table: "Cart",
                newName: "IX_Cart_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "order_id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_register_UserId1",
                table: "Order",
                column: "UserId1",
                principalTable: "register",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Statuses_StatusId",
                table: "Order",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
