using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class beenaya : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cities_countries_countryId",
                table: "cities");

            migrationBuilder.DropForeignKey(
                name: "FK_productSeasons_Statuses_StatusId",
                table: "productSeasons");

            migrationBuilder.DropIndex(
                name: "IX_productSeasons_StatusId",
                table: "productSeasons");

            migrationBuilder.DropIndex(
                name: "IX_cities_countryId",
                table: "cities");

            migrationBuilder.CreateTable(
                name: "productImages",
                columns: table => new
                {
                    productimageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<int>(type: "int", nullable: false),
                    iamgepath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imagepath_thumb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lastmodifield = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productImages", x => x.productimageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productImages");

            migrationBuilder.CreateIndex(
                name: "IX_productSeasons_StatusId",
                table: "productSeasons",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_cities_countryId",
                table: "cities",
                column: "countryId");

            migrationBuilder.AddForeignKey(
                name: "FK_cities_countries_countryId",
                table: "cities",
                column: "countryId",
                principalTable: "countries",
                principalColumn: "countryId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_productSeasons_Statuses_StatusId",
                table: "productSeasons",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
