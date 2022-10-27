using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "warehouses",
                columns: table => new
                {
                    warehouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    warehouseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    storageArea = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouses", x => x.warehouseId);
                });

            migrationBuilder.CreateTable(
                name: "storageAreas",
                columns: table => new
                {
                    storageAreaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noOfRooms = table.Column<int>(type: "int", nullable: false),
                    warehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storageAreas", x => x.storageAreaID);
                    table.ForeignKey(
                        name: "FK_storageAreas_warehouses_warehouseId",
                        column: x => x.warehouseId,
                        principalTable: "warehouses",
                        principalColumn: "warehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    roomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noOfPallets = table.Column<int>(type: "int", nullable: false),
                    noOfEmptyPallets = table.Column<int>(type: "int", nullable: false),
                    storageAreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.roomId);
                    table.ForeignKey(
                        name: "FK_rooms_storageAreas_storageAreaId",
                        column: x => x.storageAreaId,
                        principalTable: "storageAreas",
                        principalColumn: "storageAreaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pallets",
                columns: table => new
                {
                    palletId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    palletNo = table.Column<int>(type: "int", nullable: false),
                    isEmpty = table.Column<int>(type: "int", nullable: false),
                    roomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pallets", x => x.palletId);
                    table.ForeignKey(
                        name: "FK_pallets_rooms_roomId",
                        column: x => x.roomId,
                        principalTable: "rooms",
                        principalColumn: "roomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pallets_roomId",
                table: "pallets",
                column: "roomId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_storageAreaId",
                table: "rooms",
                column: "storageAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_storageAreas_warehouseId",
                table: "storageAreas",
                column: "warehouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pallets");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "storageAreas");

            migrationBuilder.DropTable(
                name: "warehouses");
        }
    }
}
