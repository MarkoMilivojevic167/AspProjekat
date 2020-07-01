using Microsoft.EntityFrameworkCore.Migrations;

namespace AspProjekat.EfDataAccess.Migrations
{
    public partial class izmena_naziva_tabele_dodavanje_kolona2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Products_ProductId",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.RenameTable(
                name: "OrderProducts",
                newName: "OrderInfo");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderInfo",
                newName: "IX_OrderInfo_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderInfo",
                newName: "IX_OrderInfo_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderInfo",
                table: "OrderInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderInfo_Orders_OrderId",
                table: "OrderInfo",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderInfo_Products_ProductId",
                table: "OrderInfo",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderInfo_Orders_OrderId",
                table: "OrderInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderInfo_Products_ProductId",
                table: "OrderInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderInfo",
                table: "OrderInfo");

            migrationBuilder.RenameTable(
                name: "OrderInfo",
                newName: "OrderProducts");

            migrationBuilder.RenameIndex(
                name: "IX_OrderInfo_ProductId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderInfo_OrderId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Products_ProductId",
                table: "OrderProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
