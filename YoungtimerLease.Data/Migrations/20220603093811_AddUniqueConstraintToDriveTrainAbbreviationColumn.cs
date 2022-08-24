using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class AddUniqueConstraintToDriveTrainAbbreviationColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_Aandrijving_Abbreviation",
                table: "Aandrijving",
                column: "Abbreviation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Aandrijving_Abbreviation",
                table: "Aandrijving");
        }
    }
}
