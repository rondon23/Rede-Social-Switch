using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AddRelacionamentoPostagem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identificacao_usuarios_UsuarioId",
                table: "Identificacao");

            migrationBuilder.DropForeignKey(
                name: "FK_postagens_usuarios_UsuarioId",
                table: "postagens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "postagens",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Identificacao",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identificacao_Usuarios_UsuarioId",
                table: "Identificacao",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_postagens_Usuarios_UsuarioId",
                table: "postagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identificacao_Usuarios_UsuarioId",
                table: "Identificacao");

            migrationBuilder.DropForeignKey(
                name: "FK_postagens_Usuarios_UsuarioId",
                table: "postagens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "usuarios",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "postagens",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Identificacao",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identificacao_usuarios_UsuarioId",
                table: "Identificacao",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_postagens_usuarios_UsuarioId",
                table: "postagens",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
