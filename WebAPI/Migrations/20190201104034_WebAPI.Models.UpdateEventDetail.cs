using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class WebAPIModelsUpdateEventDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventDetails",
                keyColumn: "EventDetailID",
                keyValue: 244668L);

            migrationBuilder.InsertData(
                table: "EventDetails",
                columns: new[] { "EventDetailID", "EventDetailName", "EventDetailNumber", "EventDetailOdd", "FK_EventDetailStatusID", "FK_EventID", "FinishingPosition", "FirstTimer" },
                values: new object[] { 2446678L, "Gallipoli", 2, 14.2900000m, 1, 155552L, 3, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventDetails",
                keyColumn: "EventDetailID",
                keyValue: 2446678L);

            migrationBuilder.InsertData(
                table: "EventDetails",
                columns: new[] { "EventDetailID", "EventDetailName", "EventDetailNumber", "EventDetailOdd", "FK_EventDetailStatusID", "FK_EventID", "FinishingPosition", "FirstTimer" },
                values: new object[] { 244668L, "Gallipoli", 2, 14.2900000m, 1, 155552L, 3, false });
        }
    }
}
