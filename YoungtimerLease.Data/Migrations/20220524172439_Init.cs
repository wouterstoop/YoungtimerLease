using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brandstoffen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brandstoffen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeasePeriodesKilometers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KilometersPerYear = table.Column<int>(type: "int", nullable: false),
                    LeasePeriodMonths = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeasePeriodesKilometers", x => x.Id);
                    table.UniqueConstraint("AK_LeasePeriodesKilometers_KilometersPerYear_LeasePeriodMonths", x => new { x.KilometersPerYear, x.LeasePeriodMonths });
                });

            migrationBuilder.CreateTable(
                name: "Auto's",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NumberOfCilinders = table.Column<int>(type: "int", nullable: true),
                    CylinderCapacity = table.Column<int>(type: "int", nullable: true),
                    DynamicPowerKw = table.Column<double>(type: "float", nullable: true),
                    AutomaticTransmission = table.Column<bool>(type: "bit", nullable: true),
                    NumberOfGears = table.Column<int>(type: "int", nullable: true),
                    Doors = table.Column<int>(type: "int", nullable: true),
                    CatalogValue = table.Column<decimal>(type: "money", nullable: true),
                    FiscalValue = table.Column<decimal>(type: "money", nullable: true),
                    TopSpeed = table.Column<int>(type: "int", nullable: true),
                    Acceleration0To100 = table.Column<double>(type: "float", nullable: true),
                    Mileage = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowOnline = table.Column<bool>(type: "bit", nullable: false),
                    Reserved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto's", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auto's_Brandstoffen_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Brandstoffen",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Leasetarieven",
                columns: table => new
                {
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeasePeriodKilometerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeaseMonthPrice = table.Column<decimal>(type: "smallmoney", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leasetarieven", x => new { x.CarId, x.LeasePeriodKilometerId });
                    table.ForeignKey(
                        name: "FK_Leasetarieven_Auto's_CarId",
                        column: x => x.CarId,
                        principalTable: "Auto's",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leasetarieven_LeasePeriodesKilometers_LeasePeriodKilometerId",
                        column: x => x.LeasePeriodKilometerId,
                        principalTable: "LeasePeriodesKilometers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto's_FuelId",
                table: "Auto's",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Leasetarieven_LeasePeriodKilometerId",
                table: "Leasetarieven",
                column: "LeasePeriodKilometerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leasetarieven");

            migrationBuilder.DropTable(
                name: "Auto's");

            migrationBuilder.DropTable(
                name: "LeasePeriodesKilometers");

            migrationBuilder.DropTable(
                name: "Brandstoffen");
        }
    }
}
