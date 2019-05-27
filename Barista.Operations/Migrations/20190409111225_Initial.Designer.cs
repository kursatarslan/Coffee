﻿// <auto-generated />
using System;
using Barista.Operations.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Barista.Operations.Migrations
{
    [DbContext(typeof(OperationsDbContext))]
    [Migration("20190409111225_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Barista.Operations.Tracking.RoutingSlipState", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateTime");

                    b.Property<TimeSpan?>("Duration");

                    b.Property<DateTime?>("EndTime");

                    b.Property<string>("FaultSummary");

                    b.Property<DateTime?>("StartTime");

                    b.Property<int>("State");

                    b.HasKey("CorrelationId");

                    b.ToTable("RoutingSlipStates");
                });
#pragma warning restore 612, 618
        }
    }
}
