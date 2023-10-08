using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class FullAuditModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "editedBy",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "modifiedAt",
                table: "Patient");

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
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "editedBy",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "modifiedAt",
                table: "Doctor");

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

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "editedBy",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "modifiedAt",
                table: "Admin");

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedDate",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "doctor_Schedule",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "doctor_Schedule",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "doctor_Schedule",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedDate",
                table: "doctor_Schedule",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedDate",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Appointment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedDate",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Admin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Admin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedDate",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "doctor_Schedule");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Admin");

            migrationBuilder.AddColumn<string>(
                name: "createdAt",
                table: "Patient",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "editedBy",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "modifiedAt",
                table: "Patient",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createdAt",
                table: "doctor_Schedule",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<string>(
                name: "modifiedAt",
                table: "doctor_Schedule",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createdAt",
                table: "Doctor",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "editedBy",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "modifiedAt",
                table: "Doctor",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createdAt",
                table: "Appointment",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<string>(
                name: "modifiedAt",
                table: "Appointment",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "createdAt",
                table: "Admin",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "editedBy",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "modifiedAt",
                table: "Admin",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
