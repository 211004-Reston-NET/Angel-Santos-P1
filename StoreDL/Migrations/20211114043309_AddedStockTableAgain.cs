using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreDL.Migrations
{
    public partial class AddedStockTableAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Price = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderId = table.Column<int>(type: "int", nullable: true),
                    LocationsStoreId = table.Column<int>(type: "int", nullable: true),
                    InventoriesInvId = table.Column<int>(type: "int", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price1 = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StockProdId__", x => x.Price);
                    table.ForeignKey(
                        name: "FK_Stock_Inventory_InventoriesInvId",
                        column: x => x.InventoriesInvId,
                        principalTable: "Inventory",
                        principalColumn: "Inv_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stock_Product_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Product",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stock_Purchase_Order_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Purchase_Order",
                        principalColumn: "Order_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stock_Store_Front_LocationsStoreId",
                        column: x => x.LocationsStoreId,
                        principalTable: "Store_Front",
                        principalColumn: "Store_Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
