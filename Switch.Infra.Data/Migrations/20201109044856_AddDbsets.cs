using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AddDbsets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupo_GrupoId",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupo_Grupo_GrupoId",
                table: "UsuarioGrupo");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                table: "UsuarioGrupo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo");

            migrationBuilder.RenameTable(
                name: "UsuarioGrupo",
                newName: "UsuariosGrupos");

            migrationBuilder.RenameTable(
                name: "Grupo",
                newName: "Grupos");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioGrupo_GrupoId",
                table: "UsuariosGrupos",
                newName: "IX_UsuariosGrupos_GrupoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuariosGrupos",
                table: "UsuariosGrupos",
                columns: new[] { "UsuarioId", "GrupoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosGrupos_Grupos_GrupoId",
                table: "UsuariosGrupos",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosGrupos_Usuarios_UsuarioId",
                table: "UsuariosGrupos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosGrupos_Grupos_GrupoId",
                table: "UsuariosGrupos");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosGrupos_Usuarios_UsuarioId",
                table: "UsuariosGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuariosGrupos",
                table: "UsuariosGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos");

            migrationBuilder.RenameTable(
                name: "UsuariosGrupos",
                newName: "UsuarioGrupo");

            migrationBuilder.RenameTable(
                name: "Grupos",
                newName: "Grupo");

            migrationBuilder.RenameIndex(
                name: "IX_UsuariosGrupos_GrupoId",
                table: "UsuarioGrupo",
                newName: "IX_UsuarioGrupo_GrupoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo",
                columns: new[] { "UsuarioId", "GrupoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupo_GrupoId",
                table: "Postagens",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupo_Grupo_GrupoId",
                table: "UsuarioGrupo",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                table: "UsuarioGrupo",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
