using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class AddFuelData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brandstoffen",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("60b33eb4-a587-478b-82db-d03fa61683e4"), "Diesel" });

            migrationBuilder.InsertData(
                table: "Brandstoffen",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("754b46e9-5b9b-47bd-970d-8d8414e22512"), "LPG" });

            migrationBuilder.InsertData(
                table: "Brandstoffen",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a7d71800-cee7-4630-8888-a535ee68169a"), "Petrol" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brandstoffen",
                keyColumn: "Id",
                keyValue: new Guid("60b33eb4-a587-478b-82db-d03fa61683e4"));

            migrationBuilder.DeleteData(
                table: "Brandstoffen",
                keyColumn: "Id",
                keyValue: new Guid("754b46e9-5b9b-47bd-970d-8d8414e22512"));

            migrationBuilder.DeleteData(
                table: "Brandstoffen",
                keyColumn: "Id",
                keyValue: new Guid("a7d71800-cee7-4630-8888-a535ee68169a"));
        }
    }
}
