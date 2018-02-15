using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CDCS.Transform.Migrations
{
    public partial class ActionZone_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CdcsId",
                table: "ActionZones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CdcsId",
                table: "ActionZones",
                nullable: true);
        }
    }
}
