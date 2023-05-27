using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriverCarAssistant.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Nubmer = table.Column<string>(type: "TEXT", nullable: false),
                    LicenseDateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LicenseDateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MaintenanceDateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MaintenanceDateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InsuranceDateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InsuranceDateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LPacketDateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LPacketDateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TachoСalibrationDateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TachoСalibrationDateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExtinguisherDateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Service = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PESEL = table.Column<int>(type: "INTEGER", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    SecondName = table.Column<string>(type: "TEXT", nullable: false),
                    Code95DateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Code95DateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TachoKardDateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TachoKardDateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "Trailers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Nubmer = table.Column<string>(type: "TEXT", nullable: false),
                    InsuranceDateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InsuranceDateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExtinguisherDateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrivingLicense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLicense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrivingLicense_Drivers_Id",
                        column: x => x.Id,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    PassportNumber = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passport_Drivers_Id",
                        column: x => x.Id,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    VisaNumber = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visa_Drivers_Id",
                        column: x => x.Id,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "DrivingLicense");

            migrationBuilder.DropTable(
                name: "Passport");

            migrationBuilder.DropTable(
                name: "Trailers");

            migrationBuilder.DropTable(
                name: "Visa");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
