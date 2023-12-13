using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDRD.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talks_Agenda_AgendaID",
                table: "Talks");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Talks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgendaID",
                table: "Talks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Talks_PersonID",
                table: "Talks",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Talks_Agenda_AgendaID",
                table: "Talks",
                column: "AgendaID",
                principalTable: "Agenda",
                principalColumn: "AgendaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talks_Person_PersonID",
                table: "Talks",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talks_Agenda_AgendaID",
                table: "Talks");

            migrationBuilder.DropForeignKey(
                name: "FK_Talks_Person_PersonID",
                table: "Talks");

            migrationBuilder.DropIndex(
                name: "IX_Talks_PersonID",
                table: "Talks");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Talks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AgendaID",
                table: "Talks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Talks_Agenda_AgendaID",
                table: "Talks",
                column: "AgendaID",
                principalTable: "Agenda",
                principalColumn: "AgendaID");
        }
    }
}
