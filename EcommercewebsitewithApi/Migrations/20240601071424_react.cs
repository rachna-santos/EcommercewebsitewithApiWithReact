using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class react : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_category_Statuses_StatusId",
                table: "category");

            migrationBuilder.DropForeignKey(
                name: "FK_category_subCategories_subCategoryId",
                table: "category");

            migrationBuilder.DropForeignKey(
                name: "FK_colors_Statuses_StatusId",
                table: "colors");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_register_UserId1",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_register_companies_CompanyId",
                table: "register");

            migrationBuilder.DropForeignKey(
                name: "FK_register_Statuses_StatusId",
                table: "register");

            migrationBuilder.DropIndex(
                name: "IX_register_CompanyId",
                table: "register");

            migrationBuilder.DropIndex(
                name: "IX_register_StatusId",
                table: "register");

            migrationBuilder.DropIndex(
                name: "IX_orders_UserId1",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_colors_StatusId",
                table: "colors");

            migrationBuilder.DropIndex(
                name: "IX_category_StatusId",
                table: "category");

            migrationBuilder.DropIndex(
                name: "IX_category_subCategoryId",
                table: "category");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "RememberMe",
                table: "login");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "register",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "userDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Confirmpassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userDetails");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "register",
                newName: "RoleName");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RememberMe",
                table: "login",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_register_CompanyId",
                table: "register",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_register_StatusId",
                table: "register",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId1",
                table: "orders",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_colors_StatusId",
                table: "colors",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_category_StatusId",
                table: "category",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_category_subCategoryId",
                table: "category",
                column: "subCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_category_Statuses_StatusId",
                table: "category",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_category_subCategories_subCategoryId",
                table: "category",
                column: "subCategoryId",
                principalTable: "subCategories",
                principalColumn: "subCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_colors_Statuses_StatusId",
                table: "colors",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_register_UserId1",
                table: "orders",
                column: "UserId1",
                principalTable: "register",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_register_companies_CompanyId",
                table: "register",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_register_Statuses_StatusId",
                table: "register",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
