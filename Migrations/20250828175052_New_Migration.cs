using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSTAPI.Migrations
{
    /// <inheritdoc />
    public partial class New_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_lookUps",
                table: "lookUps");

            migrationBuilder.RenameTable(
                name: "lookUps",
                newName: "LookUps");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LookUps",
                table: "LookUps",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LookUps",
                table: "LookUps");

            migrationBuilder.RenameTable(
                name: "LookUps",
                newName: "lookUps");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lookUps",
                table: "lookUps",
                column: "Id");
        }
    }
}
