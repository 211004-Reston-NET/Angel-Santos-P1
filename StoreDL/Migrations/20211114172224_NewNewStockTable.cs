using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreDL.Migrations
{
    public partial class NewNewStockTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Inventory_InventoriesInvId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Product_ProductsProductId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Purchase_Order_OrdersOrderId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Store_Front_LocationsStoreId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_InventoriesInvId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_LocationsStoreId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_OrdersOrderId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_ProductsProductId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "InventoriesInvId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "LocationsStoreId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OrdersOrderId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Price1",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ProductsProductId",
                table: "Stock");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Stock",
                newName: "Store_Id");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Stock",
                newName: "Product_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Store_Id",
                table: "Stock",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "Product_Id",
                table: "Stock",
                newName: "Price");

            migrationBuilder.AddColumn<int>(
                name: "InventoriesInvId",
                table: "Stock",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationsStoreId",
                table: "Stock",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrdersOrderId",
                table: "Stock",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price1",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductsProductId",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_InventoriesInvId",
                table: "Stock",
                column: "InventoriesInvId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_LocationsStoreId",
                table: "Stock",
                column: "LocationsStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_OrdersOrderId",
                table: "Stock",
                column: "OrdersOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ProductsProductId",
                table: "Stock",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Inventory_InventoriesInvId",
                table: "Stock",
                column: "InventoriesInvId",
                principalTable: "Inventory",
                principalColumn: "Inv_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Product_ProductsProductId",
                table: "Stock",
                column: "ProductsProductId",
                principalTable: "Product",
                principalColumn: "Product_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Purchase_Order_OrdersOrderId",
                table: "Stock",
                column: "OrdersOrderId",
                principalTable: "Purchase_Order",
                principalColumn: "Order_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Store_Front_LocationsStoreId",
                table: "Stock",
                column: "LocationsStoreId",
                principalTable: "Store_Front",
                principalColumn: "Store_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
