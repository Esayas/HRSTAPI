using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSTAPI.Migrations
{
    /// <inheritdoc />
    public partial class HRSTDetailmodified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BehavioralRiskOther",
                table: "HrstDetails",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PatientGroupOther",
                table: "HrstDetails",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReceivedHIVTestSameDateOther",
                table: "HrstDetails",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BehavioralRiskOther",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "PatientGroupOther",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "ReceivedHIVTestSameDateOther",
                table: "HrstDetails");
        }
    }
}
