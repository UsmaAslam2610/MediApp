using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class initMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Admin",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        createdBy = table.Column<int>(type: "int", nullable: false),
            //        editedBy = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Admin", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Doctor",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Qualification = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Expert_In = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Date_Added = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        createdBy = table.Column<int>(type: "int", nullable: false),
            //        editedBy = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Doctor", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Patient",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Gender = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Age = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
            //        createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        createdBy = table.Column<int>(type: "int", nullable: false),
            //        editedBy = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Patient", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "doctor_Schedule",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        doctor_id = table.Column<int>(type: "int", nullable: false),
            //        doctor_schedule_date = table.Column<DateTime>(type: "date", nullable: false),
            //        doctor_schedule_day = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        doctor_schedule_start_time = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        doctor_schedule_end_time = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        average_consulting_time = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        schedule_status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_doctor_Schedule", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__doctor_Sc__docto__2E1BDC42",
            //            column: x => x.doctor_id,
            //            principalTable: "Doctor",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Appointment",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        patient_id = table.Column<int>(type: "int", nullable: false),
            //        doctor_schedule_id = table.Column<int>(type: "int", nullable: false),
            //        reason = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        doctor_comment = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Appointment", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__Appointme__docto__32E0915F",
            //            column: x => x.doctor_schedule_id,
            //            principalTable: "doctor_Schedule",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK__Appointme__patie__33D4B598",
            //            column: x => x.patient_id,
            //            principalTable: "Patient",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Admin__A9D10534D60B2E07",
            //    table: "Admin",
            //    column: "Email",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Appointment_doctor_schedule_id",
            //    table: "Appointment",
            //    column: "doctor_schedule_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Appointment_patient_id",
            //    table: "Appointment",
            //    column: "patient_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Doctor__A9D10534E4F309F5",
            //    table: "Doctor",
            //    column: "Email",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_doctor_Schedule_doctor_id",
            //    table: "doctor_Schedule",
            //    column: "doctor_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Patient__A9D10534D6C462D9",
            //    table: "Patient",
            //    column: "Email",
            //    unique: true);
        }
    }
}
