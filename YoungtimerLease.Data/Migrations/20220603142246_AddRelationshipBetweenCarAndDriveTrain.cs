using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class AddRelationshipBetweenCarAndDriveTrain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriveTrain",
                table: "Auto's");

            migrationBuilder.AddColumn<Guid>(
                name: "DriveTrainId",
                table: "Auto's",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auto's_DriveTrainId",
                table: "Auto's",
                column: "DriveTrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto's_Aandrijving_DriveTrainId",
                table: "Auto's",
                column: "DriveTrainId",
                principalTable: "Aandrijving",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto's_Aandrijving_DriveTrainId",
                table: "Auto's");

            migrationBuilder.DropIndex(
                name: "IX_Auto's_DriveTrainId",
                table: "Auto's");

            migrationBuilder.DropColumn(
                name: "DriveTrainId",
                table: "Auto's");

            migrationBuilder.AddColumn<string>(
                name: "DriveTrain",
                table: "Auto's",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
