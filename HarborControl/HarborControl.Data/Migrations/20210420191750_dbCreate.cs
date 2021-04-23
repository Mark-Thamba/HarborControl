using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HarborControl.Data.Migrations
{
    public partial class dbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoatStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MesuringUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MesuringUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoatTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speed = table.Column<double>(type: "float", nullable: false),
                    MesuringUnitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoatTypes_MesuringUnits_MesuringUnitsId",
                        column: x => x.MesuringUnitsId,
                        principalTable: "MesuringUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Harbors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HarborName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parameter = table.Column<double>(type: "float", nullable: false),
                    MesuringUnitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harbors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harbors_MesuringUnits_MesuringUnitsId",
                        column: x => x.MesuringUnitsId,
                        principalTable: "MesuringUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DockedBoats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BoatTypesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoatStatusesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DockedBoats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DockedBoats_BoatStatuses_BoatStatusesId",
                        column: x => x.BoatStatusesId,
                        principalTable: "BoatStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DockedBoats_BoatTypes_BoatTypesId",
                        column: x => x.BoatTypesId,
                        principalTable: "BoatTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HarborQues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HarborsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BoatTypesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoatStatusesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarborQues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HarborQues_BoatStatuses_BoatStatusesId",
                        column: x => x.BoatStatusesId,
                        principalTable: "BoatStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HarborQues_BoatTypes_BoatTypesId",
                        column: x => x.BoatTypesId,
                        principalTable: "BoatTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HarborQues_Harbors_HarborsId",
                        column: x => x.HarborsId,
                        principalTable: "Harbors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BoatStatuses",
                columns: new[] { "Id", "Active", "CreatedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("74fd6dd2-2166-489a-a076-94b12a9d6d38"), true, new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "Docked" },
                    { new Guid("e87ef917-6010-4b4e-8ba8-0a9e99ccc8bc"), true, new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "Arriving" },
                    { new Guid("be094685-5e2b-49a2-a43c-d99462bfda2a"), true, new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "Docking" },
                    { new Guid("46b17989-5742-4fc4-8cb1-0cb982eefd8c"), true, new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "OnQueue" }
                });

            migrationBuilder.InsertData(
                table: "MesuringUnits",
                columns: new[] { "Id", "Active", "CreatedDate", "ModifiedDate", "UnitName" },
                values: new object[,]
                {
                    { new Guid("bc098656-f905-4642-9ff8-0232a7ee3a32"), true, new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "km/h" },
                    { new Guid("698366a2-f82d-4759-97f6-101e9e8a1526"), true, new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "km" },
                    { new Guid("a2ad6a55-6147-4517-b370-41a04cfc555c"), false, new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "miles" }
                });

            migrationBuilder.InsertData(
                table: "BoatTypes",
                columns: new[] { "Id", "Active", "BoatType", "CreatedDate", "MesuringUnitsId", "ModifiedDate", "Speed" },
                values: new object[,]
                {
                    { new Guid("dd23fd5d-6c80-47cc-8f8b-1e471f23185d"), true, "Speedboat", new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc098656-f905-4642-9ff8-0232a7ee3a32"), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 30.0 },
                    { new Guid("78063f1b-5e7d-4bce-9f23-e4f249163338"), true, "Sailboat", new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc098656-f905-4642-9ff8-0232a7ee3a32"), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 15.0 },
                    { new Guid("54533da8-1701-41bf-a3e8-9207c71a0b50"), true, "Cargo Ship", new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc098656-f905-4642-9ff8-0232a7ee3a32"), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Harbors",
                columns: new[] { "Id", "Active", "CreatedDate", "HarborName", "MesuringUnitsId", "ModifiedDate", "Parameter" },
                values: new object[,]
                {
                    { new Guid("36a8fc3a-501e-4943-a950-40902850bc47"), true, new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "Durban", new Guid("698366a2-f82d-4759-97f6-101e9e8a1526"), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 10.0 },
                    { new Guid("7128ac76-34e7-46aa-83d9-32dbc0a97fcd"), false, new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "Cape Town", new Guid("698366a2-f82d-4759-97f6-101e9e8a1526"), new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 10.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoatTypes_MesuringUnitsId",
                table: "BoatTypes",
                column: "MesuringUnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_DockedBoats_BoatStatusesId",
                table: "DockedBoats",
                column: "BoatStatusesId");

            migrationBuilder.CreateIndex(
                name: "IX_DockedBoats_BoatTypesId",
                table: "DockedBoats",
                column: "BoatTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_HarborQues_BoatStatusesId",
                table: "HarborQues",
                column: "BoatStatusesId");

            migrationBuilder.CreateIndex(
                name: "IX_HarborQues_BoatTypesId",
                table: "HarborQues",
                column: "BoatTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_HarborQues_HarborsId",
                table: "HarborQues",
                column: "HarborsId");

            migrationBuilder.CreateIndex(
                name: "IX_Harbors_MesuringUnitsId",
                table: "Harbors",
                column: "MesuringUnitsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DockedBoats");

            migrationBuilder.DropTable(
                name: "HarborQues");

            migrationBuilder.DropTable(
                name: "BoatStatuses");

            migrationBuilder.DropTable(
                name: "BoatTypes");

            migrationBuilder.DropTable(
                name: "Harbors");

            migrationBuilder.DropTable(
                name: "MesuringUnits");
        }
    }
}
