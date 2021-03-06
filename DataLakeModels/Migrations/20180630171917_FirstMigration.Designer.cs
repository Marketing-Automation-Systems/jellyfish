﻿// <auto-generated />
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using DataLakeModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DataLakeModels.Migrations
{
    [DbContext(typeof(DataLakeLoggingContext))]
    [Migration("20180630171917_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("logging")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("Common.Logging.Models.RuntimeLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data")
                        .HasColumnType("jsonb");

                    b.Property<string>("Exception");

                    b.Property<string>("Level");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<DateTime>("When");

                    b.HasKey("Id");

                    b.ToTable("RuntimeLog");
                });
#pragma warning restore 612, 618
        }
    }
}
