using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HarborControl.Data.Migrations
{
    public partial class updatedockingtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DockingTime",
                table: "HarborQues",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DockingTime",
                table: "HarborQues");
        }
    }
}
