using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogiTec.Data.Migrations
{
    public partial class LogiTec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    CPF = table.Column<string>(maxLength: 15, nullable: false),
                    RG = table.Column<string>(maxLength: 15, nullable: false),
                    CNH = table.Column<string>(maxLength: 15, nullable: true),
                    Nacimento = table.Column<DateTime>(nullable: false),
                    Telefones = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 200, nullable: true),
                    CEP = table.Column<string>(maxLength: 8, nullable: false),
                    Cidade = table.Column<string>(maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "Char", maxLength: 2, nullable: false),
                    RedeSociais = table.Column<string>(maxLength: 200, nullable: false),
                    Login = table.Column<string>(maxLength: 10, nullable: false),
                    Senha = table.Column<string>(maxLength: 10, nullable: false),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DadosComplementares",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    Valor = table.Column<string>(maxLength: 200, nullable: false),
                    Usuario_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosComplementares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DadosComplementares_Usuarios_Usuario_Id",
                        column: x => x.Usuario_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DadosComplementares_Usuario_Id",
                table: "DadosComplementares",
                column: "Usuario_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CNH",
                table: "Usuarios",
                column: "CNH");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CPF",
                table: "Usuarios",
                column: "CPF");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RG",
                table: "Usuarios",
                column: "RG");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosComplementares");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
