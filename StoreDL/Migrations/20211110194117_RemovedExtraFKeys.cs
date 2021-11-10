using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreDL.Migrations
{
    public partial class RemovedExtraFKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Line_Item_Product_ProductId",
                table: "Line_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Order_Store_Front_StoreFrontStoreId",
                table: "Purchase_Order");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_Order_StoreFrontStoreId",
                table: "Purchase_Order");

            migrationBuilder.DropIndex(
                name: "IX_Line_Item_ProductId",
                table: "Line_Item");

            migrationBuilder.DropColumn(
                name: "StoreFrontStoreId",
                table: "Purchase_Order");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Line_Item");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Order_Store_Id",
                table: "Purchase_Order",
                column: "Store_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Line_Item_Prod_Id",
                table: "Line_Item",
                column: "Prod_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Line_Item_Product_Prod_Id",
                table: "Line_Item",
                column: "Prod_Id",
                principalTable: "Product",
                principalColumn: "Product_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Order_Store_Front_Store_Id",
                table: "Purchase_Order",
                column: "Store_Id",
                principalTable: "Store_Front",
                principalColumn: "Store_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Line_Item_Product_Prod_Id",
                table: "Line_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Order_Store_Front_Store_Id",
                table: "Purchase_Order");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_Order_Store_Id",
                table: "Purchase_Order");

            migrationBuilder.DropIndex(
                name: "IX_Line_Item_Prod_Id",
                table: "Line_Item");

            migrationBuilder.AddColumn<int>(
                name: "StoreFrontStoreId",
                table: "Purchase_Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Line_Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Order_StoreFrontStoreId",
                table: "Purchase_Order",
                column: "StoreFrontStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Line_Item_ProductId",
                table: "Line_Item",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Line_Item_Product_ProductId",
                table: "Line_Item",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Product_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Order_Store_Front_StoreFrontStoreId",
                table: "Purchase_Order",
                column: "StoreFrontStoreId",
                principalTable: "Store_Front",
                principalColumn: "Store_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
