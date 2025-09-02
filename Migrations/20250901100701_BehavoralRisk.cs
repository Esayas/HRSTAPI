using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSTAPI.Migrations
{
    /// <inheritdoc />
    public partial class BehavoralRisk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ExchangedSexForMoney",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HistoryofSexualViolence",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MultipleSexualPartners",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NeedleSharingforInjection",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OtherBehavioralRiks",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PartnerofKnownHIVPositive",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "STIHistory",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SexWithNonRegularPartner",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SexualPracticeUnderInfluence",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UnprotectedSex",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExchangedSexForMoney",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "HistoryofSexualViolence",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "MultipleSexualPartners",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "NeedleSharingforInjection",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "OtherBehavioralRiks",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "PartnerofKnownHIVPositive",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "STIHistory",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "SexWithNonRegularPartner",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "SexualPracticeUnderInfluence",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "UnprotectedSex",
                table: "HrstDetails");
        }
    }
}
