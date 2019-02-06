using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class sp_GetTournaments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetTournaments]
                AS
                BEGIN
                    SET NOCOUNT ON;
                    SELECT * 
                    FROM Tournaments tr 
                    JOIN Events ev ON ev.FK_TournamentID = tr.TournamentID
                END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
