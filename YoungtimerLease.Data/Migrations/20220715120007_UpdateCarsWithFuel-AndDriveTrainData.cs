using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class UpdateCarsWithFuelAndDriveTrainData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("bd35e46d-04eb-465e-b399-ff3f226f952e"),
                column: "FuelId",
                value: new Guid("a7d71800-cee7-4630-8888-a535ee68169a"));

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("bd35e46d-04eb-465e-b399-ff3f226f952e"),
                    column: "DriveTrainId",
                    value: new Guid("4d99c733-29a4-4062-9838-07331f28b3f2"));


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"),
                column: "FuelId",
                value: new Guid("754b46e9-5b9b-47bd-970d-8d8414e22512"));

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"),
                    column: "DriveTrainId",
                    value: new Guid("f0d82820-6547-40b2-87c0-3a8ee62b6cb9"));


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("c6a28ade-280e-492a-9066-89882bee3d88"),
                column: "FuelId",
                value: new Guid("a7d71800-cee7-4630-8888-a535ee68169a"));

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("c6a28ade-280e-492a-9066-89882bee3d88"),
                    column: "DriveTrainId",
                    value: new Guid("f0d82820-6547-40b2-87c0-3a8ee62b6cb9"));


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"),
                column: "FuelId",
                value: new Guid("60b33eb4-a587-478b-82db-d03fa61683e4"));

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"),
                    column: "DriveTrainId",
                    value: new Guid("4d99c733-29a4-4062-9838-07331f28b3f2"));


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"),
                column: "FuelId",
                value: new Guid("a7d71800-cee7-4630-8888-a535ee68169a"));

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"),
                    column: "DriveTrainId",
                    value: new Guid("f0d82820-6547-40b2-87c0-3a8ee62b6cb9"));


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"),
                column: "FuelId",
                value: new Guid("a7d71800-cee7-4630-8888-a535ee68169a"));

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"),
                    column: "DriveTrainId",
                    value: new Guid("f0d82820-6547-40b2-87c0-3a8ee62b6cb9"));


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"),
                column: "FuelId",
                value: new Guid("a7d71800-cee7-4630-8888-a535ee68169a"));

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"),
                    column: "DriveTrainId",
                    value: new Guid("f0d82820-6547-40b2-87c0-3a8ee62b6cb9"));


            migrationBuilder.UpdateData(
            table: "Auto's",
            keyColumn: "Id",
            keyValue: new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"),
            column: "FuelId",
            value: new Guid("754b46e9-5b9b-47bd-970d-8d8414e22512"));

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"),
                    column: "DriveTrainId",
                    value: new Guid("4d99c733-29a4-4062-9838-07331f28b3f2"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
              table: "Auto's",
              keyColumn: "Id",
              keyValue: new Guid("bd35e46d-04eb-465e-b399-ff3f226f952e"),
              column: "FuelId",
              value: null);

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("bd35e46d-04eb-465e-b399-ff3f226f952e"),
                    column: "DriveTrainId",
                    value: null);


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"),
                column: "FuelId",
                value: null);

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"),
                    column: "DriveTrainId",
                    value: null);


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("c6a28ade-280e-492a-9066-89882bee3d88"),
                column: "FuelId",
                value: null); ;

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("c6a28ade-280e-492a-9066-89882bee3d88"),
                    column: "DriveTrainId",
                    value: null);


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"),
                column: "FuelId",
                value: null);

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"),
                    column: "DriveTrainId",
                    value: null);


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"),
                column: "FuelId",
                value: null);

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"),
                    column: "DriveTrainId",
                    value: null);


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"),
                column: "FuelId",
                value: null);

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"),
                    column: "DriveTrainId",
                    value: null);


            migrationBuilder.UpdateData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"),
                column: "FuelId",
                value: null);

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"),
                    column: "DriveTrainId",
                    value: null);


            migrationBuilder.UpdateData(
            table: "Auto's",
            keyColumn: "Id",
            keyValue: new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"),
            column: "FuelId",
            value: null);

            migrationBuilder.UpdateData(
                   table: "Auto's",
                    keyColumn: "Id",
                    keyValue: new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"),
                    column: "DriveTrainId",
                    value: null);

        }
    }
}
