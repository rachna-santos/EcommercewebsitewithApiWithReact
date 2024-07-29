using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class sanajaved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "sizes",
                newName: "SizeId");

            migrationBuilder.CreateTable(
                name: "categoryStyles",
                columns: table => new
                {
                    categorystyleid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categorystyleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    tag = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Keyword = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    imagepath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    subcategoryId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lastmodifield = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryStyles", x => x.categorystyleid);
                    table.ForeignKey(
                        name: "FK_categoryStyles_category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_categoryStyles_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_categoryStyles_subCategories_subcategoryId",
                        column: x => x.subcategoryId,
                        principalTable: "subCategories",
                        principalColumn: "subCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    countryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.countryId);
                });

            migrationBuilder.CreateTable(
                name: "productSeasons",
                columns: table => new
                {
                    productseasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productseasonName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    tag = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Keyword = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    imagepath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lastmodifield = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productSeasons", x => x.productseasonId);
                    table.ForeignKey(
                        name: "FK_productSeasons_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productveriations",
                columns: table => new
                {
                    veriationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    veriationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    costprice = table.Column<int>(type: "int", nullable: false),
                    RetailerPrice = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    subcategoryId = table.Column<int>(type: "int", nullable: false),
                    categorystyleid = table.Column<int>(type: "int", nullable: false),
                    genderId = table.Column<int>(type: "int", nullable: false),
                    productgenderId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lastmodifield = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productveriations", x => x.veriationId);
                    table.ForeignKey(
                        name: "FK_productveriations_category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productveriations_categoryStyles_categorystyleid",
                        column: x => x.categorystyleid,
                        principalTable: "categoryStyles",
                        principalColumn: "categorystyleid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productveriations_colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productveriations_genders_genderId",
                        column: x => x.genderId,
                        principalTable: "genders",
                        principalColumn: "genderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productveriations_materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productveriations_product_productId",
                        column: x => x.productId,
                        principalTable: "product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productveriations_sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "sizes",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productveriations_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productveriations_subCategories_subcategoryId",
                        column: x => x.subcategoryId,
                        principalTable: "subCategories",
                        principalColumn: "subCategoryId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    cityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.cityId);
                    table.ForeignKey(
                        name: "FK_cities_countries_countryId",
                        column: x => x.countryId,
                        principalTable: "countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categoryStyles_categoryId",
                table: "categoryStyles",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_categoryStyles_StatusId",
                table: "categoryStyles",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_categoryStyles_subcategoryId",
                table: "categoryStyles",
                column: "subcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_cities_countryId",
                table: "cities",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_productSeasons_StatusId",
                table: "productSeasons",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_categoryId",
                table: "productveriations",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_categorystyleid",
                table: "productveriations",
                column: "categorystyleid");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_ColorId",
                table: "productveriations",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_genderId",
                table: "productveriations",
                column: "genderId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_MaterialId",
                table: "productveriations",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_productId",
                table: "productveriations",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_SizeId",
                table: "productveriations",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_StatusId",
                table: "productveriations",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_productveriations_subcategoryId",
                table: "productveriations",
                column: "subcategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "productSeasons");

            migrationBuilder.DropTable(
                name: "productveriations");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "categoryStyles");

            migrationBuilder.RenameColumn(
                name: "SizeId",
                table: "sizes",
                newName: "Id");
        }
    }
}
