using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class ModifyTablesAndAddTableDriveTrain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_LeasePeriodesKilometers_KilometersPerYear_LeasePeriodMonths",
                table: "LeasePeriodesKilometers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Brandstoffen");

            migrationBuilder.RenameColumn(
                name: "LeaseMonthPrice",
                table: "Leasetarieven",
                newName: "FixedLeaseMonthPrice");

            migrationBuilder.AddColumn<bool>(
                name: "CalculateTariff",
                table: "Leasetarieven",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "TariffCalculationFactor",
                table: "LeasePeriodesKilometers",
                type: "decimal(3,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Brandstoffen",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DynamicPowerKw",
                table: "Auto's",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriveTrain",
                table: "Auto's",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ReferenceTariff",
                table: "Auto's",
                type: "money",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Brandstoffen_Name",
                table: "Brandstoffen",
                column: "Name");

            migrationBuilder.CreateTable(
                name: "Aandrijving",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aandrijving", x => x.Id);
                    table.UniqueConstraint("AK_Aandrijving_Name", x => x.Name);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeasePeriodesKilometers_KilometersPerYear_LeasePeriodMonths",
                table: "LeasePeriodesKilometers",
                columns: new[] { "KilometersPerYear", "LeasePeriodMonths" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aandrijving");

            migrationBuilder.DropIndex(
                name: "IX_LeasePeriodesKilometers_KilometersPerYear_LeasePeriodMonths",
                table: "LeasePeriodesKilometers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Brandstoffen_Name",
                table: "Brandstoffen");

            migrationBuilder.DropColumn(
                name: "CalculateTariff",
                table: "Leasetarieven");

            migrationBuilder.DropColumn(
                name: "TariffCalculationFactor",
                table: "LeasePeriodesKilometers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Brandstoffen");

            migrationBuilder.DropColumn(
                name: "DriveTrain",
                table: "Auto's");

            migrationBuilder.DropColumn(
                name: "ReferenceTariff",
                table: "Auto's");

            migrationBuilder.RenameColumn(
                name: "FixedLeaseMonthPrice",
                table: "Leasetarieven",
                newName: "LeaseMonthPrice");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Brandstoffen",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "DynamicPowerKw",
                table: "Auto's",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_LeasePeriodesKilometers_KilometersPerYear_LeasePeriodMonths",
                table: "LeasePeriodesKilometers",
                columns: new[] { "KilometersPerYear", "LeasePeriodMonths" });
        }
    }
}
