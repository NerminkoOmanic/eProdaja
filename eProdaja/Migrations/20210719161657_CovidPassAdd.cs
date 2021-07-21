using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProdaja.Migrations
{
    public partial class CovidPassAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CovidPass",
                columns: table => new
                {
                    CovidPassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPocetak = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumKraj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KupacId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidPass", x => x.CovidPassId);
                    table.ForeignKey(
                        name: "FK_CovidPass_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CovidPass_KupacId",
                table: "CovidPass",
                column: "KupacId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CovidPass");
        }
    }
}
