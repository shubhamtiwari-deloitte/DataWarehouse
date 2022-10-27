using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pallets_rooms_roomId",
                table: "pallets");

            migrationBuilder.DropForeignKey(
                name: "FK_rooms_storageAreas_storageAreaId",
                table: "rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_storageAreas_warehouses_warehouseId",
                table: "storageAreas");

            migrationBuilder.DropIndex(
                name: "IX_storageAreas_warehouseId",
                table: "storageAreas");

            migrationBuilder.DropIndex(
                name: "IX_rooms_storageAreaId",
                table: "rooms");

            migrationBuilder.DropIndex(
                name: "IX_pallets_roomId",
                table: "pallets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_storageAreas_warehouseId",
                table: "storageAreas",
                column: "warehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_storageAreaId",
                table: "rooms",
                column: "storageAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_pallets_roomId",
                table: "pallets",
                column: "roomId");

            migrationBuilder.AddForeignKey(
                name: "FK_pallets_rooms_roomId",
                table: "pallets",
                column: "roomId",
                principalTable: "rooms",
                principalColumn: "roomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_storageAreas_storageAreaId",
                table: "rooms",
                column: "storageAreaId",
                principalTable: "storageAreas",
                principalColumn: "storageAreaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_storageAreas_warehouses_warehouseId",
                table: "storageAreas",
                column: "warehouseId",
                principalTable: "warehouses",
                principalColumn: "warehouseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
