﻿// <auto-generated />
using System;
using Barista.Identity.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Barista.Identity.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20190319115810_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Barista.Identity.Domain.Assignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<Guid>("MeansId");

                    b.Property<DateTimeOffset>("Updated");

                    b.Property<DateTimeOffset>("ValidSince");

                    b.Property<DateTimeOffset?>("ValidUntil");

                    b.HasKey("Id");

                    b.ToTable("Assignments");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Assignment");
                });

            modelBuilder.Entity("Barista.Identity.Domain.AuthenticationMeans", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("Type");

                    b.Property<DateTimeOffset>("Updated");

                    b.Property<DateTimeOffset>("ValidSince");

                    b.Property<DateTimeOffset?>("ValidUntil");

                    b.Property<byte[]>("Value");

                    b.HasKey("Id");

                    b.ToTable("MeansOfAuthentication");
                });

            modelBuilder.Entity("Barista.Identity.Domain.SpendingLimit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AssignmentToUserId");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<TimeSpan>("Interval");

                    b.Property<DateTimeOffset>("Updated");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentToUserId");

                    b.ToTable("SpendingLimit");
                });

            modelBuilder.Entity("Barista.Identity.Domain.AssignmentToPointOfSale", b =>
                {
                    b.HasBaseType("Barista.Identity.Domain.Assignment");

                    b.Property<Guid>("PointOfSaleId");

                    b.HasDiscriminator().HasValue("AssignmentToPointOfSale");
                });

            modelBuilder.Entity("Barista.Identity.Domain.AssignmentToUser", b =>
                {
                    b.HasBaseType("Barista.Identity.Domain.Assignment");

                    b.Property<bool>("IsShared");

                    b.Property<Guid>("UserId");

                    b.HasDiscriminator().HasValue("AssignmentToUser");
                });

            modelBuilder.Entity("Barista.Identity.Domain.SpendingLimit", b =>
                {
                    b.HasOne("Barista.Identity.Domain.AssignmentToUser")
                        .WithMany("SpendingLimits")
                        .HasForeignKey("AssignmentToUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
