using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityStudie.Infra.Migrations
{
    /// <inheritdoc />
    public partial class QuestionSolicitationV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Solicitations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Solicitations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Solicitations");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Solicitations");
        }
    }
}
