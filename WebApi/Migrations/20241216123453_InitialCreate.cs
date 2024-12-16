using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WhId = table.Column<string>(type: "TEXT", nullable: false),
                    LocationId = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ShortLocationId = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Zone = table.Column<string>(type: "TEXT", nullable: false),
                    PickingFlow = table.Column<double>(type: "REAL", nullable: true),
                    CapacityUom = table.Column<string>(type: "TEXT", nullable: false),
                    CapacityQty = table.Column<int>(type: "INTEGER", nullable: false),
                    StoredQty = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    FifoDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CycleCountClass = table.Column<string>(type: "TEXT", nullable: false),
                    XCoordinate = table.Column<double>(type: "REAL", nullable: true),
                    YCoordinate = table.Column<double>(type: "REAL", nullable: true),
                    ZCoordinate = table.Column<double>(type: "REAL", nullable: true),
                    Length = table.Column<double>(type: "REAL", nullable: true),
                    Width = table.Column<double>(type: "REAL", nullable: true),
                    Height = table.Column<double>(type: "REAL", nullable: true),
                    ReplenishmentLocationId = table.Column<string>(type: "TEXT", nullable: false),
                    AllowBulkPick = table.Column<bool>(type: "INTEGER", nullable: false),
                    SlotStatus = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
