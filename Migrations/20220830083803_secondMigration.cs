using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "doctor_Schedule",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "doctor_Schedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "editedBy",
                table: "doctor_Schedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedAt",
                table: "doctor_Schedule",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "editedBy",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedAt",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "editedBy",
                table: "doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "modifiedAt",
                table: "doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "editedBy",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "modifiedAt",
                table: "Appointment");
        }
    }
}
