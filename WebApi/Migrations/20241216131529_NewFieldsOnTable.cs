using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class NewFieldsOnTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "C1",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C2",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C3",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CapacityVolume",
                table: "Locations",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentType",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemHuIndicator",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastActivityDate",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastCountDate",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastMaintained",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastPhysicalDate",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationGroup",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmAisle",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmBeam",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmClosestDoor",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmDangArea",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmHallId",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NmHighLift",
                table: "Locations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmIoLocationId",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NmIsBlockStack",
                table: "Locations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NmIsMezzanine",
                table: "Locations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NmIsSelected",
                table: "Locations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmPutawayFlow",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmSection",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmVoiceAisle",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmVoiceHall",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmVoiceLevel",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmVoicePosition",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmVoiceSection",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickArea",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RandomCc",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SlotRank",
                table: "Locations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageDeviceId",
                table: "Locations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TimeBetweenMaintenance",
                table: "Locations",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserCount",
                table: "Locations",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "C1",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "C2",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "C3",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CapacityVolume",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "EquipmentType",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "ItemHuIndicator",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LastActivityDate",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LastCountDate",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LastMaintained",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LastPhysicalDate",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LocationGroup",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmAisle",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmBeam",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmClosestDoor",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmDangArea",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmHallId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmHighLift",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmIoLocationId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmIsBlockStack",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmIsMezzanine",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmIsSelected",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmPutawayFlow",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmSection",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmVoiceAisle",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmVoiceHall",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmVoiceLevel",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmVoicePosition",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NmVoiceSection",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "PickArea",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "RandomCc",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "SlotRank",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "StorageDeviceId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "TimeBetweenMaintenance",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Locations");
        }
    }
}
