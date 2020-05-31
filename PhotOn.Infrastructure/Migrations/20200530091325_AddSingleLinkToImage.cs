﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotOn.Infrastructure.Migrations
{
    public partial class AddSingleLinkToImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateCheckConstraint(
                name: "CK_Publications_Season_Enum_Constraint",
                table: "Publications",
                sql: "[Season] IN(0, 1, 2, 3, 4)");

            migrationBuilder.CreateCheckConstraint(
                name: "CK_PublicationImages_Priority_Enum_Constraint",
                table: "PublicationImages",
                sql: "[Priority] IN(0, 1, 2)");

            migrationBuilder.AddColumn<string>(
                name: "ImageLink",
                table: "Publications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Publications_Season_Enum_Constraint",
                table: "Publications");

            migrationBuilder.DropCheckConstraint(
                name: "CK_PublicationImages_Priority_Enum_Constraint",
                table: "PublicationImages");

            migrationBuilder.DropColumn(
                name: "ImageLink",
                table: "Publications");
        }
    }
}