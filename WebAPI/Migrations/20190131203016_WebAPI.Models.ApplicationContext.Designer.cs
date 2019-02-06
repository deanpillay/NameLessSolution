﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190131203016_WebAPI.Models.ApplicationContext")]
    partial class WebAPIModelsApplicationContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Event", b =>
                {
                    b.Property<long>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AutoClose");

                    b.Property<DateTime>("EventDateTime");

                    b.Property<DateTime>("EventEndDateTime");

                    b.Property<string>("EventName");

                    b.Property<int>("EventNumber");

                    b.Property<long>("FK_TournamentID");

                    b.HasKey("EventID");

                    b.HasIndex("FK_TournamentID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("WebAPI.Models.EventDetail", b =>
                {
                    b.Property<long>("EventDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventDetailName");

                    b.Property<int>("EventDetailNumber");

                    b.Property<decimal>("EventDetailOdd");

                    b.Property<int>("FK_EventDetailStatusID");

                    b.Property<long>("FK_EventID");

                    b.Property<int>("FinishingPosition");

                    b.Property<bool>("FirstTimer");

                    b.HasKey("EventDetailID");

                    b.HasIndex("FK_EventDetailStatusID");

                    b.HasIndex("FK_EventID");

                    b.ToTable("EventDetails");
                });

            modelBuilder.Entity("WebAPI.Models.EventDetailStatus", b =>
                {
                    b.Property<int>("EventDetailStatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventDetailStatusName");

                    b.HasKey("EventDetailStatusID");

                    b.ToTable("EventDetailStatuses");
                });

            modelBuilder.Entity("WebAPI.Models.Tournament", b =>
                {
                    b.Property<long>("TournamentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TournamentName");

                    b.HasKey("TournamentID");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("WebAPI.Models.Event", b =>
                {
                    b.HasOne("WebAPI.Models.Tournament", "Tournament")
                        .WithMany("Events")
                        .HasForeignKey("FK_TournamentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models.EventDetail", b =>
                {
                    b.HasOne("WebAPI.Models.EventDetailStatus", "EventDetailStatus")
                        .WithMany()
                        .HasForeignKey("FK_EventDetailStatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models.Event", "Event")
                        .WithMany("EventDetails")
                        .HasForeignKey("FK_EventID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
