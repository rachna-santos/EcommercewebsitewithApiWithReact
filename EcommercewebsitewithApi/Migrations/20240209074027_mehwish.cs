using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercewebsitewithApi.Migrations
{
    public partial class mehwish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_orders_UserId1",
                table: "Orders",
                newName: "IX_Orders_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_orders_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_StatusId",
                table: "Orders",
                newName: "IX_Orders_StatusId");

            migrationBuilder.RenameColumn(
                name: "order_details",
                table: "order_Details",
                newName: "order_detailsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_Details_Orders_order_id",
                table: "order_Details",
                column: "order_id",
                principalTable: "Orders",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_register_UserId1",
                table: "Orders",
                column: "UserId1",
                principalTable: "register",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Statuses_StatusId",
                table: "Orders",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_Details_Orders_order_id",
                table: "order_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_register_UserId1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Statuses_StatusId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId1",
                table: "orders",
                newName: "IX_orders_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "orders",
                newName: "IX_orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StatusId",
                table: "orders",
                newName: "IX_orders_StatusId");

            migrationBuilder.RenameColumn(
                name: "order_detailsId",
                table: "order_Details",
                newName: "order_details");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
