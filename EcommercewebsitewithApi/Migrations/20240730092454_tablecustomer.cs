using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class tablecustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subCategories_Statuses_StatusId",
                table: "subCategories");

            migrationBuilder.DropIndex(
                name: "IX_subCategories_StatusId",
                table: "subCategories");

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Name = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Name);
                    table.ForeignKey(
                        name: "FK_customers_cities_CityId",
                        column: x => x.CityId,
                        principalTable: "cities",
                        principalColumn: "cityId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_customers_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "userCities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userCities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "userCountries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userCountries", x => x.CountryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_CityId",
                table: "customers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_CountryId",
                table: "customers",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "userCities");

            migrationBuilder.DropTable(
                name: "userCountries");

            migrationBuilder.CreateIndex(
                name: "IX_subCategories_StatusId",
                table: "subCategories",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_subCategories_Statuses_StatusId",
                table: "subCategories",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
