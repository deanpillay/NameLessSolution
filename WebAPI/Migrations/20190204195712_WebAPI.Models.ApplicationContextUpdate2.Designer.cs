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
    [Migration("20190204195712_WebAPI.Models.ApplicationContextUpdate2")]
    partial class WebAPIModelsApplicationContextUpdate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebAPI.Models.Event", b =>
                {
                    b.Property<long>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AutoClose");

                    b.Property<DateTime>("EventDateTime");

                    b.Property<DateTime>("EventEndDateTime");

                    b.Property<string>("EventName")
                        .HasMaxLength(100);

                    b.Property<int>("EventNumber");

                    b.Property<long>("FK_TournamentID");

                    b.HasKey("EventID");

                    b.HasIndex("FK_TournamentID");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventID = 151536L,
                            AutoClose = true,
                            EventDateTime = new DateTime(2013, 4, 24, 4, 0, 0, 0, DateTimeKind.Unspecified),
                            EventEndDateTime = new DateTime(2013, 4, 24, 5, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Race",
                            EventNumber = 1,
                            FK_TournamentID = 1198159L
                        },
                        new
                        {
                            EventID = 151537L,
                            AutoClose = true,
                            EventDateTime = new DateTime(2013, 4, 24, 4, 0, 0, 0, DateTimeKind.Unspecified),
                            EventEndDateTime = new DateTime(2013, 4, 24, 5, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Race",
                            EventNumber = 1,
                            FK_TournamentID = 1198159L
                        },
                        new
                        {
                            EventID = 155552L,
                            AutoClose = true,
                            EventDateTime = new DateTime(2013, 5, 7, 11, 45, 0, 0, DateTimeKind.Unspecified),
                            EventEndDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Race",
                            EventNumber = 1,
                            FK_TournamentID = 1198680L
                        },
                        new
                        {
                            EventID = 155553L,
                            AutoClose = true,
                            EventDateTime = new DateTime(2013, 5, 7, 12, 20, 0, 0, DateTimeKind.Unspecified),
                            EventEndDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Race",
                            EventNumber = 2,
                            FK_TournamentID = 1198680L
                        },
                        new
                        {
                            EventID = 155554L,
                            AutoClose = true,
                            EventDateTime = new DateTime(2013, 5, 7, 12, 55, 0, 0, DateTimeKind.Unspecified),
                            EventEndDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Race",
                            EventNumber = 3,
                            FK_TournamentID = 1198680L
                        },
                        new
                        {
                            EventID = 155555L,
                            AutoClose = true,
                            EventDateTime = new DateTime(2013, 5, 7, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            EventEndDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Race",
                            EventNumber = 4,
                            FK_TournamentID = 1198680L
                        },
                        new
                        {
                            EventID = 155556L,
                            AutoClose = true,
                            EventDateTime = new DateTime(2013, 5, 7, 14, 5, 0, 0, DateTimeKind.Unspecified),
                            EventEndDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Race",
                            EventNumber = 5,
                            FK_TournamentID = 1198680L
                        },
                        new
                        {
                            EventID = 155557L,
                            AutoClose = true,
                            EventDateTime = new DateTime(2013, 5, 7, 14, 40, 0, 0, DateTimeKind.Unspecified),
                            EventEndDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Race",
                            EventNumber = 6,
                            FK_TournamentID = 1198680L
                        });
                });

            modelBuilder.Entity("WebAPI.Models.EventDetail", b =>
                {
                    b.Property<long>("EventDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventDetailName")
                        .HasMaxLength(50);

                    b.Property<int>("EventDetailNumber");

                    b.Property<decimal>("EventDetailOdd")
                        .HasColumnType("money");

                    b.Property<int>("FK_EventDetailStatusID");

                    b.Property<long>("FK_EventID");

                    b.Property<int>("FinishingPosition");

                    b.Property<bool>("FirstTimer");

                    b.HasKey("EventDetailID");

                    b.HasIndex("FK_EventDetailStatusID");

                    b.HasIndex("FK_EventID");

                    b.ToTable("EventDetails");

                    b.HasData(
                        new
                        {
                            EventDetailID = 2446677L,
                            EventDetailName = "Auriferous",
                            EventDetailNumber = 1,
                            EventDetailOdd = 8.3300000m,
                            FK_EventDetailStatusID = 1,
                            FK_EventID = 155552L,
                            FinishingPosition = 1,
                            FirstTimer = false
                        },
                        new
                        {
                            EventDetailID = 2446678L,
                            EventDetailName = "Gallipoli",
                            EventDetailNumber = 2,
                            EventDetailOdd = 14.2900000m,
                            FK_EventDetailStatusID = 1,
                            FK_EventID = 155552L,
                            FinishingPosition = 3,
                            FirstTimer = false
                        },
                        new
                        {
                            EventDetailID = 2446679L,
                            EventDetailName = "Ninja Warrior",
                            EventDetailNumber = 3,
                            EventDetailOdd = 10.0000000m,
                            FK_EventDetailStatusID = 1,
                            FK_EventID = 155552L,
                            FinishingPosition = 2,
                            FirstTimer = false
                        },
                        new
                        {
                            EventDetailID = 2446680L,
                            EventDetailName = "Scientist",
                            EventDetailNumber = 4,
                            EventDetailOdd = 20.0000000m,
                            FK_EventDetailStatusID = 1,
                            FK_EventID = 155552L,
                            FinishingPosition = 4,
                            FirstTimer = false
                        },
                        new
                        {
                            EventDetailID = 2446681L,
                            EventDetailName = "Augusta Pines",
                            EventDetailNumber = 5,
                            EventDetailOdd = 33.3300000m,
                            FK_EventDetailStatusID = 1,
                            FK_EventID = 155552L,
                            FinishingPosition = 0,
                            FirstTimer = false
                        },
                        new
                        {
                            EventDetailID = 2446682L,
                            EventDetailName = "Golden Guinea",
                            EventDetailNumber = 6,
                            EventDetailOdd = 33.3300000m,
                            FK_EventDetailStatusID = 1,
                            FK_EventID = 155552L,
                            FinishingPosition = 0,
                            FirstTimer = false
                        },
                        new
                        {
                            EventDetailID = 2446683L,
                            EventDetailName = "Royal Stock",
                            EventDetailNumber = 7,
                            EventDetailOdd = 50.0000000m,
                            FK_EventDetailStatusID = 1,
                            FK_EventID = 155552L,
                            FinishingPosition = 0,
                            FirstTimer = false
                        });
                });

            modelBuilder.Entity("WebAPI.Models.EventDetailStatus", b =>
                {
                    b.Property<int>("EventDetailStatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventDetailStatusName")
                        .HasMaxLength(50);

                    b.HasKey("EventDetailStatusID");

                    b.ToTable("EventDetailStatuses");

                    b.HasData(
                        new
                        {
                            EventDetailStatusID = 1,
                            EventDetailStatusName = "Active"
                        },
                        new
                        {
                            EventDetailStatusID = 2,
                            EventDetailStatusName = "Scratched"
                        },
                        new
                        {
                            EventDetailStatusID = 3,
                            EventDetailStatusName = "Closed"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Tournament", b =>
                {
                    b.Property<long>("TournamentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TournamentName")
                        .HasMaxLength(200);

                    b.HasKey("TournamentID");

                    b.ToTable("Tournaments");

                    b.HasData(
                        new
                        {
                            TournamentID = 1198159L,
                            TournamentName = "Jockey 2013"
                        },
                        new
                        {
                            TournamentID = 1198680L,
                            TournamentName = "Vaal"
                        });
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
