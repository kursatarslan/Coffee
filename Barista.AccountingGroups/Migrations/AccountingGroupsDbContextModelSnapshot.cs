﻿// <auto-generated />
using System;
using Barista.AccountingGroups.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Barista.AccountingGroups.Migrations
{
    [DbContext(typeof(AccountingGroupsDbContext))]
    partial class AccountingGroupsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Barista.AccountingGroups.Domain.AccountingGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("DisplayName");

                    b.Property<Guid>("SaleStrategyId");

                    b.Property<DateTimeOffset>("Updated");

                    b.HasKey("Id");

                    b.ToTable("AccountingGroups");
                });

            modelBuilder.Entity("Barista.AccountingGroups.Domain.UserAuthorization", b =>
                {
                    b.Property<Guid>("AccountingGroupId");

                    b.Property<Guid>("UserId");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<int>("Level");

                    b.Property<DateTimeOffset>("Updated");

                    b.HasKey("AccountingGroupId", "UserId");

                    b.ToTable("UserAuthorizations");
                });
#pragma warning restore 612, 618
        }
    }
}
