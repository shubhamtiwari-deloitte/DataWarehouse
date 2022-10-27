﻿// <auto-generated />
using Inventory.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221026192515_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Inventory.Models.Pallet", b =>
                {
                    b.Property<string>("palletId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("isEmpty")
                        .HasColumnType("bit");

                    b.Property<int>("palletNo")
                        .HasColumnType("int");

                    b.Property<string>("roomId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("palletId");

                    b.ToTable("pallets");
                });

            modelBuilder.Entity("Inventory.Models.Room", b =>
                {
                    b.Property<string>("roomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("noOfEmptyPallets")
                        .HasColumnType("int");

                    b.Property<int>("noOfPallets")
                        .HasColumnType("int");

                    b.Property<int>("storageAreaId")
                        .HasColumnType("int");

                    b.HasKey("roomId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("Inventory.Models.StorageArea", b =>
                {
                    b.Property<string>("storageAreaID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("noOfRooms")
                        .HasColumnType("int");

                    b.Property<int>("warehouseId")
                        .HasColumnType("int");

                    b.HasKey("storageAreaID");

                    b.ToTable("storageAreas");
                });

            modelBuilder.Entity("Inventory.Models.Warehouse", b =>
                {
                    b.Property<string>("warehouseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("warehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("warehouseId");

                    b.ToTable("warehouses");
                });
#pragma warning restore 612, 618
        }
    }
}
