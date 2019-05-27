﻿// <auto-generated />
using System;
using Barista.PointsOfSale.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Barista.PointsOfSale.Migrations
{
    [DbContext(typeof(PointsOfSaleDbContext))]
    [Migration("20190514081051_KeyValues")]
    partial class KeyValues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Barista.PointsOfSale.Domain.PointOfSale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("DisplayName");

                    b.Property<Guid>("ParentAccountingGroupId");

                    b.Property<Guid?>("SaleStrategyId");

                    b.Property<DateTimeOffset>("Updated");

                    b.HasKey("Id");

                    b.ToTable("PointsOfSale");
                });

            modelBuilder.Entity("Barista.PointsOfSale.Domain.PointOfSaleKeyValue", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Key");

                    b.Property<DateTimeOffset>("LastUpdated");

                    b.Property<Guid?>("PointOfSaleId");

                    b.Property<string>("Value");

                    b.HasKey("Id", "Key");

                    b.HasIndex("PointOfSaleId");

                    b.ToTable("PointOfSaleKeyValue");
                });

            modelBuilder.Entity("Barista.PointsOfSale.Domain.UserAuthorization", b =>
                {
                    b.Property<Guid>("PointOfSaleId");

                    b.Property<Guid>("UserId");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<int>("Level");

                    b.Property<DateTimeOffset>("Updated");

                    b.HasKey("PointOfSaleId", "UserId");

                    b.ToTable("UserAuthorizations");
                });

            modelBuilder.Entity("Barista.PointsOfSale.Domain.PointOfSaleKeyValue", b =>
                {
                    b.HasOne("Barista.PointsOfSale.Domain.PointOfSale")
                        .WithMany("KeyValues")
                        .HasForeignKey("PointOfSaleId");
                });
#pragma warning restore 612, 618
        }
    }
}
