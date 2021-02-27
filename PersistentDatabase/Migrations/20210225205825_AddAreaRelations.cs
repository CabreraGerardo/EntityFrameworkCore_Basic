using Microsoft.EntityFrameworkCore.Migrations;

namespace PersistentDatabase.Migrations
{
    public partial class AddAreaRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PisoId",
                table: "Areas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PisoId1",
                table: "Areas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Edificios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edificios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pisos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EdificioId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EdificioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pisos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pisos_Edificios_EdificioId1",
                        column: x => x.EdificioId1,
                        principalTable: "Edificios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_PisoId1",
                table: "Areas",
                column: "PisoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pisos_EdificioId1",
                table: "Pisos",
                column: "EdificioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Pisos_PisoId1",
                table: "Areas",
                column: "PisoId1",
                principalTable: "Pisos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Pisos_PisoId1",
                table: "Areas");

            migrationBuilder.DropTable(
                name: "Pisos");

            migrationBuilder.DropTable(
                name: "Edificios");

            migrationBuilder.DropIndex(
                name: "IX_Areas_PisoId1",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "PisoId",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "PisoId1",
                table: "Areas");
        }
    }
}
