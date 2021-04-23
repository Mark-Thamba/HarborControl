using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HarborControl.Data.Migrations
{
    public partial class updateLookupTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnitName",
                table: "MesuringUnits",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "HarborName",
                table: "Harbors",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MesuringUnits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Harbors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "BoatStatuses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BoatStatuses",
                keyColumn: "Id",
                keyValue: new Guid("46b17989-5742-4fc4-8cb1-0cb982eefd8c"),
                column: "Code",
                value: "OnQu");

            migrationBuilder.UpdateData(
                table: "BoatStatuses",
                keyColumn: "Id",
                keyValue: new Guid("74fd6dd2-2166-489a-a076-94b12a9d6d38"),
                column: "Code",
                value: "Docke");

            migrationBuilder.UpdateData(
                table: "BoatStatuses",
                keyColumn: "Id",
                keyValue: new Guid("be094685-5e2b-49a2-a43c-d99462bfda2a"),
                column: "Code",
                value: "Docki");

            migrationBuilder.UpdateData(
                table: "BoatStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e87ef917-6010-4b4e-8ba8-0a9e99ccc8bc"),
                column: "Code",
                value: "Arri");

            migrationBuilder.UpdateData(
                table: "Harbors",
                keyColumn: "Id",
                keyValue: new Guid("36a8fc3a-501e-4943-a950-40902850bc47"),
                column: "Code",
                value: "durb");

            migrationBuilder.UpdateData(
                table: "Harbors",
                keyColumn: "Id",
                keyValue: new Guid("7128ac76-34e7-46aa-83d9-32dbc0a97fcd"),
                column: "Code",
                value: "cape");

            migrationBuilder.UpdateData(
                table: "MesuringUnits",
                keyColumn: "Id",
                keyValue: new Guid("698366a2-f82d-4759-97f6-101e9e8a1526"),
                column: "Code",
                value: "km");

            migrationBuilder.UpdateData(
                table: "MesuringUnits",
                keyColumn: "Id",
                keyValue: new Guid("a2ad6a55-6147-4517-b370-41a04cfc555c"),
                column: "Code",
                value: "kmh");

            migrationBuilder.UpdateData(
                table: "MesuringUnits",
                keyColumn: "Id",
                keyValue: new Guid("bc098656-f905-4642-9ff8-0232a7ee3a32"),
                column: "Code",
                value: "kmh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "MesuringUnits");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Harbors");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "BoatStatuses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MesuringUnits",
                newName: "UnitName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Harbors",
                newName: "HarborName");
        }
    }
}
