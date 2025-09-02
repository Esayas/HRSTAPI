using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSTAPI.Migrations
{
    /// <inheritdoc />
    public partial class PatientGroupModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClinicalSignType",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "PatientGroup",
                table: "HrstDetails");

            migrationBuilder.AddColumn<bool>(
                name: "CMVInfections",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CNSRelatedInfectionsLymphoma",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CervicalCarcinoma",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ClinicalSignOther",
                table: "HrstDetails",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "DivorcedWidowWidower",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EsophagealCandidiasis",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HerpesZoster",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HighRiskAdolescentGirlYoungWomen",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "KaposiSarcoma",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Leishmaniosis",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LongDistanceDriver",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OralUlceration",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OtherPatientGroup",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OtherSign",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PCP",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PWID",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PersistentGeneralizedLymphadenopathy",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PresumptiveTBConfirmedTB",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Prisoners",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RecurrentRespiratoryTractInfections",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RecurrentSevereBacterialInfections",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "STI",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SexualPartnerPLHIV",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SkinRelatedProblem",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UnexplainedChronicDiarrhea",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UnexplainedPersistentFever",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UnexplainedPersistentHepatosplenomegaly",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UnexplainedWeightLoss",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WomenEngagedCommercialSex",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WorkersHotSpotArea",
                table: "HrstDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CMVInfections",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "CNSRelatedInfectionsLymphoma",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "CervicalCarcinoma",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "ClinicalSignOther",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "DivorcedWidowWidower",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "EsophagealCandidiasis",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "HerpesZoster",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "HighRiskAdolescentGirlYoungWomen",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "KaposiSarcoma",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "Leishmaniosis",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "LongDistanceDriver",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "OralUlceration",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "OtherPatientGroup",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "OtherSign",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "PCP",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "PWID",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "PersistentGeneralizedLymphadenopathy",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "PresumptiveTBConfirmedTB",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "Prisoners",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "RecurrentRespiratoryTractInfections",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "RecurrentSevereBacterialInfections",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "STI",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "SexualPartnerPLHIV",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "SkinRelatedProblem",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "UnexplainedChronicDiarrhea",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "UnexplainedPersistentFever",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "UnexplainedPersistentHepatosplenomegaly",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "UnexplainedWeightLoss",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "WomenEngagedCommercialSex",
                table: "HrstDetails");

            migrationBuilder.DropColumn(
                name: "WorkersHotSpotArea",
                table: "HrstDetails");

            migrationBuilder.AddColumn<int>(
                name: "ClinicalSignType",
                table: "HrstDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientGroup",
                table: "HrstDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
