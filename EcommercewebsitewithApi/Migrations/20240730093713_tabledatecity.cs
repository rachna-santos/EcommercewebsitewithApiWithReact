using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class tabledatecity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Createdate",
                table: "userCountries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "lastdate",
                table: "userCountries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "userCities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Createdate",
                table: "userCities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "lastdate",
                table: "userCities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_userCities_CountryId",
                table: "userCities",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_userCities_countries_CountryId",
                table: "userCities",
                column: "CountryId",
                principalTable: "countries",
                principalColumn: "countryId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userCities_countries_CountryId",
                table: "userCities");

            migrationBuilder.DropIndex(
                name: "IX_userCities_CountryId",
                table: "userCities");

            migrationBuilder.DropColumn(
                name: "Createdate",
                table: "userCountries");

            migrationBuilder.DropColumn(
                name: "lastdate",
                table: "userCountries");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "userCities");

            migrationBuilder.DropColumn(
                name: "Createdate",
                table: "userCities");

            migrationBuilder.DropColumn(
                name: "lastdate",
                table: "userCities");
        }
    }
}
