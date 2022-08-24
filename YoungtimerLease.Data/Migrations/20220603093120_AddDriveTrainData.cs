using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class AddDriveTrainData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Aandrijving",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { new Guid("27d0a389-5f93-4dce-b7e8-4cd85e2b7d51"), "AWD", "All-wheel drive" });

            migrationBuilder.InsertData(
                table: "Aandrijving",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { new Guid("4d99c733-29a4-4062-9838-07331f28b3f2"), "FWD", "Front-wheel drive" });

            migrationBuilder.InsertData(
                table: "Aandrijving",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { new Guid("f0d82820-6547-40b2-87c0-3a8ee62b6cb9"), "RWD", "Rear-wheel drive" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aandrijving",
                keyColumn: "Id",
                keyValue: new Guid("27d0a389-5f93-4dce-b7e8-4cd85e2b7d51"));

            migrationBuilder.DeleteData(
                table: "Aandrijving",
                keyColumn: "Id",
                keyValue: new Guid("4d99c733-29a4-4062-9838-07331f28b3f2"));

            migrationBuilder.DeleteData(
                table: "Aandrijving",
                keyColumn: "Id",
                keyValue: new Guid("f0d82820-6547-40b2-87c0-3a8ee62b6cb9"));
        }
    }
}
