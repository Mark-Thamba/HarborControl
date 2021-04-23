using Microsoft.EntityFrameworkCore.Migrations;

namespace HarborControl.Data.Migrations
{
    public partial class updatedockingtbl1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DockingBoats_BoatStatuses_BoatStatusesId",
                table: "DockingBoats");

            migrationBuilder.DropForeignKey(
                name: "FK_DockingBoats_BoatTypes_BoatTypesId",
                table: "DockingBoats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DockingBoats",
                table: "DockingBoats");

            migrationBuilder.RenameTable(
                name: "DockingBoats",
                newName: "DockedBoats");

            migrationBuilder.RenameIndex(
                name: "IX_DockingBoats_BoatTypesId",
                table: "DockedBoats",
                newName: "IX_DockedBoats_BoatTypesId");

            migrationBuilder.RenameIndex(
                name: "IX_DockingBoats_BoatStatusesId",
                table: "DockedBoats",
                newName: "IX_DockedBoats_BoatStatusesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DockedBoats",
                table: "DockedBoats",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DockedBoats_BoatStatuses_BoatStatusesId",
                table: "DockedBoats",
                column: "BoatStatusesId",
                principalTable: "BoatStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DockedBoats_BoatTypes_BoatTypesId",
                table: "DockedBoats",
                column: "BoatTypesId",
                principalTable: "BoatTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DockedBoats_BoatStatuses_BoatStatusesId",
                table: "DockedBoats");

            migrationBuilder.DropForeignKey(
                name: "FK_DockedBoats_BoatTypes_BoatTypesId",
                table: "DockedBoats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DockedBoats",
                table: "DockedBoats");

            migrationBuilder.RenameTable(
                name: "DockedBoats",
                newName: "DockingBoats");

            migrationBuilder.RenameIndex(
                name: "IX_DockedBoats_BoatTypesId",
                table: "DockingBoats",
                newName: "IX_DockingBoats_BoatTypesId");

            migrationBuilder.RenameIndex(
                name: "IX_DockedBoats_BoatStatusesId",
                table: "DockingBoats",
                newName: "IX_DockingBoats_BoatStatusesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DockingBoats",
                table: "DockingBoats",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DockingBoats_BoatStatuses_BoatStatusesId",
                table: "DockingBoats",
                column: "BoatStatusesId",
                principalTable: "BoatStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DockingBoats_BoatTypes_BoatTypesId",
                table: "DockingBoats",
                column: "BoatTypesId",
                principalTable: "BoatTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
