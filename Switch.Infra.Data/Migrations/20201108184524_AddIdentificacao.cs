using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AddIdentificacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                oldType: "varchar(400) CHARACTER SET utf8mb4",
                oldMaxLength: 400)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400) CHARACTER SET utf8mb4",
                oldMaxLength: 400)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "varchar(400) CHARACTER SET utf8mb4",
                oldMaxLength: 400)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400) CHARACTER SET utf8mb4",
                oldMaxLength: 400)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "varchar(400) CHARACTER SET utf8mb4",
                oldMaxLength: 400)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "usuarios",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Identificacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoDocumento = table.Column<int>(nullable: false),
                    Numero = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identificacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identificacao_usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Identificacao_UsuarioId",
                table: "Identificacao",
                column: "UsuarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Identificacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "Usuarios",
                type: "varchar(400) CHARACTER SET utf8mb4",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "Usuarios",
                type: "varchar(400) CHARACTER SET utf8mb4",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "varchar(400) CHARACTER SET utf8mb4",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)",
                oldDefaultValueSql: "''")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "varchar(400) CHARACTER SET utf8mb4",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "varchar(400) CHARACTER SET utf8mb4",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)",
                oldDefaultValueSql: "''")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Usuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");
        }
    }
}
