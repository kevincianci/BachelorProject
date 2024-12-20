﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241216131529_NewFieldsOnTable")]
    partial class NewFieldsOnTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("WebApi.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("AllowBulkPick")
                        .HasColumnType("INTEGER");

                    b.Property<string>("C1")
                        .HasColumnType("TEXT");

                    b.Property<string>("C2")
                        .HasColumnType("TEXT");

                    b.Property<string>("C3")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CapacityQty")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CapacityUom")
                        .HasColumnType("TEXT");

                    b.Property<double?>("CapacityVolume")
                        .HasColumnType("REAL");

                    b.Property<string>("CycleCountClass")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("EquipmentType")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FifoDate")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Height")
                        .HasColumnType("REAL");

                    b.Property<string>("ItemHuIndicator")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastActivityDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastCountDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastMaintained")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastPhysicalDate")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Length")
                        .HasColumnType("REAL");

                    b.Property<string>("LocationGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("LocationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmAisle")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmBeam")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmClosestDoor")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmDangArea")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmHallId")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("NmHighLift")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NmIoLocationId")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("NmIsBlockStack")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("NmIsMezzanine")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("NmIsSelected")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NmPutawayFlow")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmSection")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmVoiceAisle")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmVoiceHall")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmVoiceLevel")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmVoicePosition")
                        .HasColumnType("TEXT");

                    b.Property<string>("NmVoiceSection")
                        .HasColumnType("TEXT");

                    b.Property<string>("PickArea")
                        .HasColumnType("TEXT");

                    b.Property<double?>("PickingFlow")
                        .HasColumnType("REAL");

                    b.Property<string>("RandomCc")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReplenishmentLocationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortLocationId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SlotRank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SlotStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("StorageDeviceId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StoredQty")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("TimeBetweenMaintenance")
                        .HasColumnType("REAL");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WhId")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Width")
                        .HasColumnType("REAL");

                    b.Property<double?>("XCoordinate")
                        .HasColumnType("REAL");

                    b.Property<double?>("YCoordinate")
                        .HasColumnType("REAL");

                    b.Property<double?>("ZCoordinate")
                        .HasColumnType("REAL");

                    b.Property<string>("Zone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
