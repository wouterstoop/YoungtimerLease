using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungtimerLease.Data.Migrations
{
    public partial class AddCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Auto's",
                columns: new[] { "Id", "Acceleration0To100", "AutomaticTransmission", "CatalogValue", "ConstructionDate", "CylinderCapacity", "Description", "Doors", "DriveTrainId", "DynamicPowerKw", "FiscalValue", "FuelId", "Make", "Mileage", "Model", "NumberOfCilinders", "NumberOfGears", "ReferenceTariff", "Reserved", "ShowOnline", "Title", "TopSpeed" },
                values: new object[,]
                {
                    { new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"), 5.7000000000000002, false, 72283m, new DateTime(1998, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1990, null, 2, null, 226, 12000m, null, "MASERATI", 140000, "Ghibli II GT 2.0 V6 24V Biturbo", 6, 6, null, false, true, null, 260 },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), 4.9000000000000004, true, null, new DateTime(2006, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4244, null, 2, null, 295, 22000m, null, "MASERATI", 130000, "GranSport (Vialle LPI)", 8, 6, 880m, false, true, null, 290 },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), 6.7000000000000002, false, 45515m, new DateTime(2005, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3179, null, 2, null, 177, 5000m, null, "ALFA ROMEO", 195000, "GT 3.2 V6 24V (Vialle LPI)", 6, 6, 570m, false, true, null, 243 },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), 4.2000000000000002, false, 220000m, new DateTime(2007, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4691, null, 2, null, 331, 30000m, null, "ALFA ROMEO", 30000, "8C Competizione", 8, 6, 1080m, false, true, null, 293 },
                    { new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"), 4.5, false, 181480m, new DateTime(2003, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3586, null, 2, null, 226, 20000m, null, "FERRARI", 80000, "360 Modena 3.6 V8", 8, 6, 1050m, false, true, null, 295 },
                    { new Guid("bd35e46d-04eb-465e-b399-ff3f226f952e"), 10.6, false, null, new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1749, null, 4, null, 85, 1500m, null, "ALFA ROMEO", 90000, "155 1.7 ts", 4, 5, 400m, true, true, null, 191 },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), 5.4000000000000004, false, 119005m, new DateTime(2007, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4799, null, 2, null, 270, 7000m, null, "BMW", 160000, "E63 6 Series Coupe 650i", 8, 6, 690m, false, true, null, 250 },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), 9.5999999999999996, false, null, new DateTime(2007, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1910, null, 2, null, 110, 1700m, null, "ALFA ROMEO", 190000, "GT 1.9 JTD MJet 16v", 4, 6, 420m, false, false, null, 209 }
                });

            migrationBuilder.InsertData(
                table: "Leasetarieven",
                columns: new[] { "CarId", "LeasePeriodKilometerId", "CalculateTariff", "FixedLeaseMonthPrice" },
                values: new object[,]
                {
                    { new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd"), false, 840m },
                    { new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1"), false, 850m },
                    { new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06"), false, 780m },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("4021bc38-0535-4f5c-954b-396b677abeec"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b"), true, null },
                    { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d"), true, null },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab"), true, null },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d"), true, null },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd"), false, 410m },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082"), true, null },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b"), true, null },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5"), true, null },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633"), true, null },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1"), false, 580m },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06"), false, 490m },
                    { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("4021bc38-0535-4f5c-954b-396b677abeec"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b"), true, null },
                    { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d"), true, null },
                    { new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd"), true, null },
                    { new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1"), true, null },
                    { new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d"), true, null }
                });

            migrationBuilder.InsertData(
                table: "Leasetarieven",
                columns: new[] { "CarId", "LeasePeriodKilometerId", "CalculateTariff", "FixedLeaseMonthPrice" },
                values: new object[,]
                {
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("4021bc38-0535-4f5c-954b-396b677abeec"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b"), true, null },
                    { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("4021bc38-0535-4f5c-954b-396b677abeec"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b"), true, null },
                    { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d"), true, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("bd35e46d-04eb-465e-b399-ff3f226f952e"));

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("4021bc38-0535-4f5c-954b-396b677abeec") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"), new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("4021bc38-0535-4f5c-954b-396b677abeec") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"), new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("4021bc38-0535-4f5c-954b-396b677abeec") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("c6a28ade-280e-492a-9066-89882bee3d88"), new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("02c68411-ce8b-49ce-94b4-b31951c37fab") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("231898b4-2c78-45e9-bebe-0698bd83468d") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("4021bc38-0535-4f5c-954b-396b677abeec") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("5664ea11-60ff-4ff4-abce-99247bb655bd") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("66773e7a-ec64-4a17-b81f-1f7aeaf78082") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("89bd1aa2-4684-4e29-a3aa-a8a0baaad75b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("976a427f-c133-4068-abe9-7baa3e85e2b5") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("ac7f24f6-fbc2-45f0-8b73-617945bce633") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("b7894c6a-2258-4aa0-8f33-22cf276214e1") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("e61134ab-9f8a-44f1-b38c-aa024d05ef06") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("fa5c3d42-a363-4fa6-a404-95a5b2d4fc7b") });

            migrationBuilder.DeleteData(
                table: "Leasetarieven",
                keyColumns: new[] { "CarId", "LeasePeriodKilometerId" },
                keyValues: new object[] { new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"), new Guid("fec6d349-05a1-4992-9748-d2ab62fe742d") });

            migrationBuilder.DeleteData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("06379cd5-2ad7-4607-9312-c22d11ae0a27"));

            migrationBuilder.DeleteData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("18708ae4-8668-4748-ba5d-4bf8202d2255"));

            migrationBuilder.DeleteData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("35f95ad3-ff01-4de3-a53e-ddeb59f6e5ca"));

            migrationBuilder.DeleteData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("408f616c-336c-44a2-9bf1-ceb0b50c3c79"));

            migrationBuilder.DeleteData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("8159f7f4-8629-48b0-ad9b-d055f74caa52"));

            migrationBuilder.DeleteData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("c6a28ade-280e-492a-9066-89882bee3d88"));

            migrationBuilder.DeleteData(
                table: "Auto's",
                keyColumn: "Id",
                keyValue: new Guid("ec25d2ce-51e9-41e6-9fa9-b71cc1b6079e"));
        }
    }
}
