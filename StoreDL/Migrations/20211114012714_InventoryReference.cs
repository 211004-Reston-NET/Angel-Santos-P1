using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreDL.Migrations
{
    public partial class InventoryReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoreFrontStoreId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreFrontStoreId",
                table: "Inventory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_StoreFrontStoreId",
                table: "Product",
                column: "StoreFrontStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_StoreFrontStoreId",
                table: "Inventory",
                column: "StoreFrontStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Store_Front_StoreFrontStoreId",
                table: "Inventory",
                column: "StoreFrontStoreId",
                principalTable: "Store_Front",
                principalColumn: "Store_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Store_Front_StoreFrontStoreId",
                table: "Product",
                column: "StoreFrontStoreId",
                principalTable: "Store_Front",
                principalColumn: "Store_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Store_Front_StoreFrontStoreId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Store_Front_StoreFrontStoreId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_StoreFrontStoreId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_StoreFrontStoreId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "StoreFrontStoreId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "StoreFrontStoreId",
                table: "Inventory");
        }
    }
}
