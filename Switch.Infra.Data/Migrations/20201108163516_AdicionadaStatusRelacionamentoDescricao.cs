using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AdicionadaStatusRelacionamentoDescricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusRelacionamentos",
                table: "StatusRelacionamentos");

            migrationBuilder.RenameTable(
                name: "StatusRelacionamentos",
                newName: "StatusRelacionamento");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "StatusRelacionamento",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusRelacionamento",
                table: "StatusRelacionamento",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusRelacionamento",
                table: "StatusRelacionamento");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "StatusRelacionamento");

            migrationBuilder.RenameTable(
                name: "StatusRelacionamento",
                newName: "StatusRelacionamentos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusRelacionamentos",
                table: "StatusRelacionamentos",
                column: "Id");
        }
    }
}
