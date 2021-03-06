﻿// <auto-generated />
using System;
using Barista.Consistency.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Barista.Consistency.Migrations
{
    [DbContext(typeof(ConsistencyDbContext))]
    partial class ConsistencyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Barista.Consistency.Domain.ScheduledEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("MessageTypeName");

                    b.Property<DateTimeOffset>("ScheduledFor");

                    b.Property<string>("SerializedContents");

                    b.Property<DateTimeOffset>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("ScheduledFor");

                    b.ToTable("ScheduledEvents");

                    b.HasData(
                        new
                        {
                            Id = new Guid("02070c27-4939-4d94-96e4-463ff617ff18"),
                            Created = new DateTimeOffset(new DateTime(2019, 5, 27, 13, 49, 40, 264, DateTimeKind.Unspecified).AddTicks(8266), new TimeSpan(0, 0, 0, 0, 0)),
                            MessageTypeName = "Barista.Contracts.Events.Consistency.IDatabaseCreated, Barista.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
                            ScheduledFor = new DateTimeOffset(new DateTime(2019, 5, 27, 13, 49, 40, 264, DateTimeKind.Unspecified).AddTicks(6654), new TimeSpan(0, 0, 0, 0, 0)),
                            SerializedContents = "{}",
                            Updated = new DateTimeOffset(new DateTime(2019, 5, 27, 13, 49, 40, 264, DateTimeKind.Unspecified).AddTicks(8268), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
