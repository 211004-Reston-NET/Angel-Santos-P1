using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreDL.Migrations
{
    public partial class InvCheckTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Order_Store_Front_Store_Id",
                table: "Purchase_Order");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_Order_Store_Id",
                table: "Purchase_Order");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_Prod_Id",
                table: "Inventory");

            migrationBuilder.CreateTable(
                name: "StoreInvCheck",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Store_Id = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StockProdId__", x => x.Product_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_Prod_Id",
                table: "Inventory",
                column: "Prod_Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreInvCheck");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_Prod_Id",
                table: "Inventory");

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

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Order_Store_Id",
                table: "Purchase_Order",
                column: "Store_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_Prod_Id",
                table: "Inventory",
                column: "Prod_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Order_Store_Front_Store_Id",
                table: "Purchase_Order",
                column: "Store_Id",
                principalTable: "Store_Front",
                principalColumn: "Store_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
