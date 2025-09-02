using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSTAPI.Migrations
{
    /// <inheritdoc />
    public partial class BehevioralRiskDropped2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BehavioralRiskType",
                table: "HrstDetails",
                newName: "BehavioralRisk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BehavioralRisk",
                table: "HrstDetails",
                newName: "BehavioralRiskType");
        }
    }
}
