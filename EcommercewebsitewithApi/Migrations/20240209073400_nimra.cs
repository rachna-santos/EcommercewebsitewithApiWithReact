using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class nimra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_AspNetUsers_UserId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_register_UserId1",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_Statuses_StatusId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_Details_order_order_id1",
                table: "order_Details");

            migrationBuilder.DropIndex(
                name: "IX_order_Details_order_id1",
                table: "order_Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order",
                table: "order");

            migrationBuilder.DropColumn(
                name: "order_id1",
                table: "order_Details");

            migrationBuilder.RenameTable(
                name: "order",
                newName: "orders");

            migrationBuilder.RenameIndex(
                name: "IX_order_UserId1",
                table: "orders",
                newName: "IX_orders_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_order_UserId",
                table: "orders",
                newName: "IX_orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_order_StatusId",
                table: "orders",
                newName: "IX_orders_StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_Details_order_id",
                table: "order_Details",
                column: "order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_Details_orders_order_id",
                table: "order_Details",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_AspNetUsers_UserId",
                table: "orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_register_UserId1",
                table: "orders",
                column: "UserId1",
                principalTable: "register",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Statuses_StatusId",
                table: "orders",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_Details_orders_order_id",
                table: "order_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_AspNetUsers_UserId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_register_UserId1",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_Statuses_StatusId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_order_Details_order_id",
                table: "order_Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "order");

            migrationBuilder.RenameIndex(
                name: "IX_orders_UserId1",
                table: "order",
                newName: "IX_order_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_orders_UserId",
                table: "order",
                newName: "IX_order_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_StatusId",
                table: "order",
                newName: "IX_order_StatusId");

            migrationBuilder.AddColumn<int>(
                name: "order_id1",
                table: "order_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_order",
                table: "order",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_Details_order_id1",
                table: "order_Details",
                column: "order_id1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_order_Details_order_order_id1",
                table: "order_Details",
                column: "order_id1",
                principalTable: "order",
                principalColumn: "order_id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
