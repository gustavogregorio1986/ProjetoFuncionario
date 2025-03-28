using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFuncionario.Data.Migrations
{
    public partial class CriarTabelaFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Funcionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeFuncionario = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    EmailCorporativo = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Cpf = table.Column<string>(type: "NVARCHAR(11)", nullable: false),
                    Emnpresa = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    Setor = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    Ativo = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Funcionario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Funcionario");
        }
    }
}
