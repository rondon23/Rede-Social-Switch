using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AddIdentificacao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)",
                oldDefaultValueSql: "''")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)",
                oldDefaultValueSql: "''")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "statusrelacionamento",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "postagens",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "SobreNome",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "usuarios",
                type: "varchar(400)",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "varchar(400)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "statusrelacionamento",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "postagens",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");
        }
    }
}
