using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class AddLeasePeriodKilometerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeasePeriodesKilometers",
                columns: new[] { "Id", "KilometersPerYear", "LeasePeriodMonths", "TariffCalculationFactor" },
                values: new object[,]
                {
                    { new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab"), 30000, 12, 1.5m },
                    { new Guid("231898b4-2c78-45e9-bebe-0698bd83468d"), 20000, 36, 1.17m },
                    { new Guid("4021bc38-0535-4f5c-954b-396b677abeec"), 10000, 48, null },
                    { new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd"), 10000, 36, 0.9m },
                    { new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082"), 40000, 12, 1.7m },
                    { new Guid("759e7365-b2bb-4639-a628-f5084a140164"), 20000, 48, null },
                    { new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b"), 20000, 24, 1.235m },
                    { new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5"), 40000, 24, 1.615m },
                    { new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633"), 30000, 24, 1.425m },
                    { new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1"), 10000, 12, 1m },
                    { new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06"), 10000, 24, 0.95m },
                    { new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b"), 20000, 12, 1.3m },
                    { new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d"), 30000, 36, 1.35m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("231898b4-2c78-45e9-bebe-0698bd83468d"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("4021bc38-0535-4f5c-954b-396b677abeec"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("759e7365-b2bb-4639-a628-f5084a140164"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b"));

            migrationBuilder.DeleteData(
                table: "LeasePeriodesKilometers",
                keyColumn: "Id",
                keyValue: new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d"));
        }
    }
}
