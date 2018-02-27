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

namespace DataLakeModels.Migrations.DataLakeYouTubeAnalytics
{
    [DbContext(typeof(DataLakeYouTubeAnalyticsContext))]
    [Migration("20180707205557_AddViewerPercentageLastDateTable")]
    partial class AddViewerPercentageLastDateTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("youtube_analytics_v2")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("DataLakeModels.Models.YouTube.Analytics.VideoDailyMetric", b =>
                {
                    b.Property<string>("VideoId");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("ValidityStart");

                    b.Property<long>("AverageViewDuration");

                    b.Property<long>("Comments");

                    b.Property<long>("Dislikes");

                    b.Property<long>("Likes");

                    b.Property<long>("Shares");

                    b.Property<long>("SubscribersGained");

                    b.Property<long>("SubscribersLost");

                    b.Property<DateTime>("ValidityEnd");

                    b.Property<long>("VideosAddedToPlaylists");

                    b.Property<long>("VideosRemovedFromPlaylists");

                    b.Property<long>("Views");

                    b.HasKey("VideoId", "Date", "ValidityStart");

                    b.ToTable("VideoDailyMetrics");
                });

            modelBuilder.Entity("DataLakeModels.Models.YouTube.Analytics.ViewerPercentage", b =>
                {
                    b.Property<string>("VideoId");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Gender");

                    b.Property<string>("AgeGroup");

                    b.Property<DateTime>("ValidityStart");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("ValidityEnd");

                    b.Property<double>("Value");

                    b.HasKey("VideoId", "StartDate", "Gender", "AgeGroup", "ValidityStart");

                    b.ToTable("ViewerPercentageMetric");
                });

            modelBuilder.Entity("DataLakeModels.Models.YouTube.Analytics.ViewerPercentageLastDate", b =>
                {
                    b.Property<string>("VideoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.HasKey("VideoId");

                    b.ToTable("ViewerPercentageLastDates");
                });
#pragma warning restore 612, 618
        }
    }
}
