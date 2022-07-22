using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSempreIT.Migrations
{
    public partial class FirstMigartion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDoProjeto = table.Column<string>(nullable: false),
                    ResponsavelPeloProjeto = table.Column<string>(nullable: false),
                    DataDeInicio = table.Column<DateTime>(nullable: false),
                    DataDeConclusao = table.Column<DateTime>(nullable: false),
                    DataDeCriacaoDoRegistros = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projetos");
        }
    }
}
