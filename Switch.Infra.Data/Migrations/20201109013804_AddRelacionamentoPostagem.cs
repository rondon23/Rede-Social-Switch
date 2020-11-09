using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AddRelacionamentoPostagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "postagens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_postagens_UsuarioId",
                table: "postagens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_postagens_usuarios_UsuarioId",
                table: "postagens",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postagens_usuarios_UsuarioId",
                table: "postagens");

            migrationBuilder.DropIndex(
                name: "IX_postagens_UsuarioId",
                table: "postagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "postagens");
        }
    }
}
