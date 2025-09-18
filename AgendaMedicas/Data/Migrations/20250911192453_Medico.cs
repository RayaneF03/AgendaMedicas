using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaMedicas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Medico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadeId1",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_EspecialidadeId1",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "EspecialidadeId1",
                table: "Medicos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "EspecialidadeId",
                table: "Medicos",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CRM",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_EspecialidadeId",
                table: "Medicos",
                column: "EspecialidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadeId",
                table: "Medicos",
                column: "EspecialidadeId",
                principalTable: "Especialidades",
                principalColumn: "EspecialidadeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadeId",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_EspecialidadeId",
                table: "Medicos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EspecialidadeId",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CRM",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EspecialidadeId1",
                table: "Medicos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_EspecialidadeId1",
                table: "Medicos",
                column: "EspecialidadeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidades_EspecialidadeId1",
                table: "Medicos",
                column: "EspecialidadeId1",
                principalTable: "Especialidades",
                principalColumn: "EspecialidadeId");
        }
    }
}
