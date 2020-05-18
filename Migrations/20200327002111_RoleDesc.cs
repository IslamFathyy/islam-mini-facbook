﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Facbook.Migrations
{
    public partial class RoleDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
             name: "Description",
             table: "AspNetRoles",
             nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
              name: "Description",
              table: "AspNetRoles");
        }
    }
}
