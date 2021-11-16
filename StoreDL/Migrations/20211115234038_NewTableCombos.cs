using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreDL.Migrations
{
    public partial class NewTableCombos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Purchase_Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Purchase_Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StoreInvCheck",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId1 = table.Column<int>(type: "int", nullable: false),
                    InventoryInvId = table.Column<int>(type: "int", nullable: true),
                    StoreFrontStoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StoreInvCheck__A2F2A30CAD3172F2", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_StoreInvCheck_Inventory_InventoryInvId",
                        column: x => x.InventoryInvId,
                        principalTable: "Inventory",
                        principalColumn: "Inv_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreInvCheck_Product_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Product",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreInvCheck_Store_Front_StoreFrontStoreId",
                        column: x => x.StoreFrontStoreId,
                        principalTable: "Store_Front",
                        principalColumn: "Store_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreInvCheck_InventoryInvId",
                table: "StoreInvCheck",
                column: "InventoryInvId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreInvCheck_ProductId1",
                table: "StoreInvCheck",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_StoreInvCheck_StoreFrontStoreId",
                table: "StoreInvCheck",
                column: "StoreFrontStoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreInvCheck");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Purchase_Order");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Purchase_Order");

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Store_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StockProdId__", x => x.Product_Id);
                });
        }
    }
}
