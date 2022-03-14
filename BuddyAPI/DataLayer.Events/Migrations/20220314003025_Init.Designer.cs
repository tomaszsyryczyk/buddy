﻿// <auto-generated />
using System;
using DataLayer.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Events.Migrations
{
    [DbContext(typeof(EventDbContext))]
    [Migration("20220314003025_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusinessLogic.Wallet.Events.AddSourceEvent", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("When")
                        .HasColumnType("datetimeoffset");

                    b.ToTable("AddSourceEvent");
                });

            modelBuilder.Entity("BusinessLogic.Wallet.Events.DeleteSourceEvent", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("When")
                        .HasColumnType("datetimeoffset");

                    b.ToTable("DeleteSourceEvent");
                });

            modelBuilder.Entity("BusinessLogic.Wallet.Events.EditSourceEvent", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("When")
                        .HasColumnType("datetimeoffset");

                    b.ToTable("EditSourceEvent");
                });

            modelBuilder.Entity("BusinessLogic.Wallet.Events.WalletRecordEvent", b =>
                {
                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SourceId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("When")
                        .HasColumnType("datetimeoffset");

                    b.ToTable("WalletRecordEvent");
                });
#pragma warning restore 612, 618
        }
    }
}
