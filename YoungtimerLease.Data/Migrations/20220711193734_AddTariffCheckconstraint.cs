using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class AddTariffCheckconstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "tariffceckconstraint",
                table: "Leasetarieven",
                sql: "FixedLeaseMonthPrice is null OR CalculateTariff=0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "tariffceckconstraint",
                table: "Leasetarieven");
        }
    }
}
