using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class WebAPIModelsApplicationContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventDetailStatuses",
                columns: new[] { "EventDetailStatusID", "EventDetailStatusName" },
                values: new object[,]
                {
                    { 1, "Active" },
                    { 2, "Scratched" },
                    { 3, "Closed" }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "TournamentID", "TournamentName" },
                values: new object[,]
                {
                    { 1198159L, "Jockey 2013" },
                    { 1198680L, "Vaal" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventID", "AutoClose", "EventDateTime", "EventEndDateTime", "EventName", "EventNumber", "FK_TournamentID" },
                values: new object[,]
                {
                    { 151536L, true, new DateTime(2013, 4, 24, 4, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 4, 24, 5, 0, 0, 0, DateTimeKind.Unspecified), "Race", 1, 1198159L },
                    { 151537L, true, new DateTime(2013, 4, 24, 4, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 4, 24, 5, 0, 0, 0, DateTimeKind.Unspecified), "Race", 1, 1198159L },
                    { 155552L, true, new DateTime(2013, 5, 7, 11, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Race", 1, 1198680L },
                    { 155553L, true, new DateTime(2013, 5, 7, 12, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Race", 2, 1198680L },
                    { 155554L, true, new DateTime(2013, 5, 7, 12, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Race", 3, 1198680L },
                    { 155555L, true, new DateTime(2013, 5, 7, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Race", 4, 1198680L },
                    { 155556L, true, new DateTime(2013, 5, 7, 14, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Race", 5, 1198680L },
                    { 155557L, true, new DateTime(2013, 5, 7, 14, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Race", 6, 1198680L }
                });

            migrationBuilder.InsertData(
                table: "EventDetails",
                columns: new[] { "EventDetailID", "EventDetailName", "EventDetailNumber", "EventDetailOdd", "FK_EventDetailStatusID", "FK_EventID", "FinishingPosition", "FirstTimer" },
                values: new object[,]
                {
                    { 2446677L, "Auriferous", 1, 8.3300000m, 1, 155552L, 1, false },
                    { 244668L, "Gallipoli", 2, 14.2900000m, 1, 155552L, 3, false },
                    { 2446679L, "Ninja Warrior", 3, 10.0000000m, 1, 155552L, 2, false },
                    { 2446680L, "Scientist", 4, 20.0000000m, 1, 155552L, 4, false },
                    { 2446681L, "Augusta Pines", 5, 33.3300000m, 1, 155552L, 0, false },
                    { 2446682L, "Golden Guinea", 6, 33.3300000m, 1, 155552L, 0, false },
                    { 2446683L, "Royal Stock", 7, 50.0000000m, 1, 155552L, 0, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventDetailStatuses",
                keyColumn: "EventDetailStatusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventDetailStatuses",
                keyColumn: "EventDetailStatusID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventDetails",
                keyColumn: "EventDetailID",
                keyValue: 244668L);

            migrationBuilder.DeleteData(
                table: "EventDetails",
                keyColumn: "EventDetailID",
                keyValue: 2446677L);

            migrationBuilder.DeleteData(
                table: "EventDetails",
                keyColumn: "EventDetailID",
                keyValue: 2446679L);

            migrationBuilder.DeleteData(
                table: "EventDetails",
                keyColumn: "EventDetailID",
                keyValue: 2446680L);

            migrationBuilder.DeleteData(
                table: "EventDetails",
                keyColumn: "EventDetailID",
                keyValue: 2446681L);

            migrationBuilder.DeleteData(
                table: "EventDetails",
                keyColumn: "EventDetailID",
                keyValue: 2446682L);

            migrationBuilder.DeleteData(
                table: "EventDetails",
                keyColumn: "EventDetailID",
                keyValue: 2446683L);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 151536L);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 151537L);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 155553L);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 155554L);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 155555L);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 155556L);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 155557L);

            migrationBuilder.DeleteData(
                table: "EventDetailStatuses",
                keyColumn: "EventDetailStatusID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 155552L);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "TournamentID",
                keyValue: 1198159L);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "TournamentID",
                keyValue: 1198680L);
        }
    }
}
