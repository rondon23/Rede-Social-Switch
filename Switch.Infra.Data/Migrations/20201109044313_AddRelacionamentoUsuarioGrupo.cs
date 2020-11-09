using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AddRelacionamentoUsuarioGrupo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postagens_Usuarios_UsuarioId",
                table: "postagens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_statusrelacionamento",
                table: "statusrelacionamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_postagens",
                table: "postagens");

            migrationBuilder.RenameTable(
                name: "statusrelacionamento",
                newName: "StatusRelacionamento");

            migrationBuilder.RenameTable(
                name: "postagens",
                newName: "Postagens");

            migrationBuilder.RenameIndex(
                name: "IX_postagens_UsuarioId",
                table: "Postagens",
                newName: "IX_Postagens_UsuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "StatusRelacionamento",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StatusRelacionamento",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Postagens",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Postagens",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Postagens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusRelacionamento",
                table: "StatusRelacionamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postagens",
                table: "Postagens",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    UrlFoto = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioGrupo",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false),
                    GrupoId = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    EhAdministrador = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioGrupo", x => new { x.UsuarioId, x.GrupoId });
                    table.ForeignKey(
                        name: "FK_UsuarioGrupo_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagens",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioGrupo_GrupoId",
                table: "UsuarioGrupo",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupo_GrupoId",
                table: "Postagens",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupo_GrupoId",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens");

            migrationBuilder.DropTable(
                name: "UsuarioGrupo");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusRelacionamento",
                table: "StatusRelacionamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postagens",
                table: "Postagens");

            migrationBuilder.DropIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Postagens");

            migrationBuilder.RenameTable(
                name: "StatusRelacionamento",
                newName: "statusrelacionamento");

            migrationBuilder.RenameTable(
                name: "Postagens",
                newName: "postagens");

            migrationBuilder.RenameIndex(
                name: "IX_Postagens_UsuarioId",
                table: "postagens",
                newName: "IX_postagens_UsuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "statusrelacionamento",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "statusrelacionamento",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "postagens",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "postagens",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_statusrelacionamento",
                table: "statusrelacionamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_postagens",
                table: "postagens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_postagens_Usuarios_UsuarioId",
                table: "postagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
