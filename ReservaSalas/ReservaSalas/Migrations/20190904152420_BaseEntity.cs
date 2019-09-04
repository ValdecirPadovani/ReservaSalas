using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservaSalas.Migrations
{
    public partial class BaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaID",
                table: "reservas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_reservas_SalaID",
                table: "reservas",
                column: "SalaID");

            migrationBuilder.AddForeignKey(
                name: "FK_reservas_salas_SalaID",
                table: "reservas",
                column: "SalaID",
                principalTable: "salas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reservas_salas_SalaID",
                table: "reservas");

            migrationBuilder.DropIndex(
                name: "IX_reservas_SalaID",
                table: "reservas");

            migrationBuilder.DropColumn(
                name: "SalaID",
                table: "reservas");
        }
    }
}
