using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Models
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<EventDetailStatus> EventDetailStatuses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tournament>().HasData(new Tournament
            {
                TournamentID = 1198159,
                TournamentName = "Jockey 2013"

            }, new Tournament
            {
                TournamentID = 1198680,
                TournamentName = "Vaal"
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventID = 151536,
                FK_TournamentID = 1198159,
                EventName = "Race",
                EventNumber = 1,
                EventDateTime = new DateTime(2013,04,24,04,00,00,000),
                EventEndDateTime = new DateTime(2013, 04, 24, 05, 00, 00, 000),
                AutoClose = true

            }, new Event
            {
                EventID = 151537,
                FK_TournamentID = 1198159,
                EventName = "Race",
                EventNumber = 1,
                EventDateTime = new DateTime(2013, 04, 24, 04, 00, 00, 000),
                EventEndDateTime = new DateTime(2013, 04, 24, 05, 00, 00, 000),
                AutoClose = true

            },
            new Event
            {
                EventID = 155552,
                FK_TournamentID = 1198680,
                EventName = "Race",
                EventNumber = 1,
                EventDateTime = new DateTime(2013, 05, 07, 11, 45, 00, 000),                
                AutoClose = true

            },
            new Event
            {
                EventID = 155553,
                FK_TournamentID = 1198680,
                EventName = "Race",
                EventNumber = 2,
                EventDateTime = new DateTime(2013, 05, 07, 12, 20, 00, 000),
                AutoClose = true

            },
            new Event
            {
                EventID = 155554,
                FK_TournamentID = 1198680,
                EventName = "Race",
                EventNumber = 3,
                EventDateTime = new DateTime(2013, 05, 07, 12, 55, 00, 000),
                AutoClose = true

            },
            new Event
            {
                EventID = 155555,
                FK_TournamentID = 1198680,
                EventName = "Race",
                EventNumber = 4,
                EventDateTime = new DateTime(2013, 05, 07, 13, 30, 00, 000),
                AutoClose = true

            },
            new Event
            {
                EventID = 155556,
                FK_TournamentID = 1198680,
                EventName = "Race",
                EventNumber = 5,
                EventDateTime = new DateTime(2013, 05, 07, 14, 05, 00, 000),
                AutoClose = true

            },
            new Event
            {
                EventID = 155557,
                FK_TournamentID = 1198680,
                EventName = "Race",
                EventNumber = 6,
                EventDateTime = new DateTime(2013, 05, 07, 14, 40, 00, 000),
                AutoClose = true

            });

            modelBuilder.Entity<EventDetailStatus>().HasData(new EventDetailStatus
            {
                EventDetailStatusID = 1,
                EventDetailStatusName = "Active"

            }, new EventDetailStatus
            {
                EventDetailStatusID = 2,
                EventDetailStatusName = "Scratched"

            },
            new EventDetailStatus
            {
                EventDetailStatusID = 3,
                EventDetailStatusName = "Closed"

            });

            modelBuilder.Entity<EventDetail>().HasData(new EventDetail
            {
                EventDetailID = 2446677,
                FK_EventID = 155552,
                FK_EventDetailStatusID = 1,
                EventDetailName = "Auriferous",
                EventDetailNumber = 1,
                EventDetailOdd = 8.3300000m,
                FinishingPosition = 1,
                FirstTimer = false

            }, new EventDetail
            {
                EventDetailID = 2446678,
                FK_EventID = 155552,
                FK_EventDetailStatusID = 1,
                EventDetailName = "Gallipoli",
                EventDetailNumber = 2,
                EventDetailOdd = 14.2900000m,
                FinishingPosition = 3,
                FirstTimer = false

            }, new EventDetail
            {
                EventDetailID = 2446679,
                FK_EventID = 155552,
                FK_EventDetailStatusID = 1,
                EventDetailName = "Ninja Warrior",
                EventDetailNumber = 3,
                EventDetailOdd = 10.0000000m,
                FinishingPosition = 2,
                FirstTimer = false

            }, new EventDetail
            {
                EventDetailID = 2446680,
                FK_EventID = 155552,
                FK_EventDetailStatusID = 1,
                EventDetailName = "Scientist",
                EventDetailNumber = 4,
                EventDetailOdd = 20.0000000m,
                FinishingPosition = 4,
                FirstTimer = false

            }, new EventDetail
            {
                EventDetailID = 2446681,
                FK_EventID = 155552,
                FK_EventDetailStatusID = 1,
                EventDetailName = "Augusta Pines",
                EventDetailNumber = 5,
                EventDetailOdd = 33.3300000m,
                FirstTimer = false

            }, new EventDetail
            {
                EventDetailID = 2446682,
                FK_EventID = 155552,
                FK_EventDetailStatusID = 1,
                EventDetailName = "Golden Guinea",
                EventDetailNumber = 6,
                EventDetailOdd = 33.3300000m,                
                FirstTimer = false

            },new EventDetail
            {
                EventDetailID = 2446683,
                FK_EventID = 155552,
                FK_EventDetailStatusID = 1,
                EventDetailName = "Royal Stock",
                EventDetailNumber = 7,
                EventDetailOdd = 50.0000000m,
                FirstTimer = false

            });
        }
    }
}
