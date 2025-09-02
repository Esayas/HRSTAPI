using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSTAPI.Migrations
{
    /// <inheritdoc />
    public partial class Firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HrstDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<int>(type: "int", nullable: false),
                    ScreenedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mrn = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    KnownHIVPositive = table.Column<int>(type: "int", nullable: false),
                    PatientOnART = table.Column<int>(type: "int", nullable: false),
                    BehavioralRisk = table.Column<int>(type: "int", nullable: false),
                    BehavioralRiskType = table.Column<int>(type: "int", nullable: false),
                    ClinicalSign = table.Column<int>(type: "int", nullable: false),
                    ClinicalSignType = table.Column<int>(type: "int", nullable: false),
                    PatientGroup = table.Column<int>(type: "int", nullable: false),
                    EligibleForTesting = table.Column<int>(type: "int", nullable: false),
                    ReceivedHIVTestSameDate = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<int>(type: "int", nullable: false),
                    HIVTestResult = table.Column<int>(type: "int", nullable: false),
                    EscortedForLinkage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HrstDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HrstDetails");
        }
    }
}
