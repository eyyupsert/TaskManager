using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Migrations
{
    public partial class TaskManagerMG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departmanlars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmanAd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmanlars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personellers",
                columns: table => new
                {
                    personelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personelAd = table.Column<string>(nullable: true),
                    personelSoyad = table.Column<string>(nullable: true),
                    iseBaslamaTarihi = table.Column<DateTime>(nullable: false),
                    telNo = table.Column<string>(nullable: true),
                    mailAdres = table.Column<string>(nullable: true),
                    departId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personellers", x => x.personelId);
                    table.ForeignKey(
                        name: "FK_personellers_departmanlars_departId",
                        column: x => x.departId,
                        principalTable: "departmanlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "gorevs",
                columns: table => new
                {
                    gorevId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gorevAd = table.Column<string>(nullable: true),
                    gorevDetay = table.Column<string>(nullable: true),
                    gorevDurum = table.Column<bool>(nullable: false),
                    gorevSonTeslimTarihi = table.Column<DateTime>(nullable: false),
                    personelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gorevs", x => x.gorevId);
                    table.ForeignKey(
                        name: "FK_gorevs_personellers_personelId",
                        column: x => x.personelId,
                        principalTable: "personellers",
                        principalColumn: "personelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_gorevs_personelId",
                table: "gorevs",
                column: "personelId");

            migrationBuilder.CreateIndex(
                name: "IX_personellers_departId",
                table: "personellers",
                column: "departId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gorevs");

            migrationBuilder.DropTable(
                name: "personellers");

            migrationBuilder.DropTable(
                name: "departmanlars");
        }
    }
}
