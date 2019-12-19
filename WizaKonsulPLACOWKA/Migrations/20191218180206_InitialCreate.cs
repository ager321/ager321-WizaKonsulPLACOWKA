using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WizaKonsulPLACOWKA.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sprawa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tresc = table.Column<string>(nullable: true),
                    ImieKlienta = table.Column<string>(nullable: true),
                    NazwiskoKlienta = table.Column<string>(nullable: true),
                    AdresKlienta = table.Column<string>(nullable: true),
                    NrDokumentuKlienta = table.Column<string>(nullable: true),
                    TypDokumentuKlienta = table.Column<string>(nullable: true),
                    ZdjecieKlienta = table.Column<string>(nullable: true),
                    Decyzja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprawa", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sprawa");
        }
    }
}
