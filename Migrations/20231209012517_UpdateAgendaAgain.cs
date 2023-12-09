using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDRD.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAgendaAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    HymnID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HymnNumber = table.Column<int>(type: "int", nullable: false),
                    HymnName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.HymnID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonPrefix = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    AgendaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpeningHymnID = table.Column<int>(type: "int", nullable: true),
                    SacramentHymnID = table.Column<int>(type: "int", nullable: true),
                    IntermediateHymnID = table.Column<int>(type: "int", nullable: true),
                    SpecialMusicalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingHymnID = table.Column<int>(type: "int", nullable: true),
                    PresidingPersonID = table.Column<int>(type: "int", nullable: true),
                    ConductingPersonID = table.Column<int>(type: "int", nullable: true),
                    OpeningPrayerPersonID = table.Column<int>(type: "int", nullable: true),
                    ClosingPrayerPersonID = table.Column<int>(type: "int", nullable: true),
                    NonSpeakerProgram = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.AgendaID);
                    table.ForeignKey(
                        name: "FK_Agenda_Hymn_ClosingHymnID",
                        column: x => x.ClosingHymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
                    table.ForeignKey(
                        name: "FK_Agenda_Hymn_IntermediateHymnID",
                        column: x => x.IntermediateHymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
                    table.ForeignKey(
                        name: "FK_Agenda_Hymn_OpeningHymnID",
                        column: x => x.OpeningHymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
                    table.ForeignKey(
                        name: "FK_Agenda_Hymn_SacramentHymnID",
                        column: x => x.SacramentHymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
                    table.ForeignKey(
                        name: "FK_Agenda_Person_ClosingPrayerPersonID",
                        column: x => x.ClosingPrayerPersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID");
                    table.ForeignKey(
                        name: "FK_Agenda_Person_ConductingPersonID",
                        column: x => x.ConductingPersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID");
                    table.ForeignKey(
                        name: "FK_Agenda_Person_OpeningPrayerPersonID",
                        column: x => x.OpeningPrayerPersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID");
                    table.ForeignKey(
                        name: "FK_Agenda_Person_PresidingPersonID",
                        column: x => x.PresidingPersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID");
                });

            migrationBuilder.CreateTable(
                name: "Talks",
                columns: table => new
                {
                    TalkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgendaID = table.Column<int>(type: "int", nullable: true),
                    PersonID = table.Column<int>(type: "int", nullable: true),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talks", x => x.TalkID);
                    table.ForeignKey(
                        name: "FK_Talks_Agenda_AgendaID",
                        column: x => x.AgendaID,
                        principalTable: "Agenda",
                        principalColumn: "AgendaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_ClosingHymnID",
                table: "Agenda",
                column: "ClosingHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_ClosingPrayerPersonID",
                table: "Agenda",
                column: "ClosingPrayerPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_ConductingPersonID",
                table: "Agenda",
                column: "ConductingPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_IntermediateHymnID",
                table: "Agenda",
                column: "IntermediateHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_OpeningHymnID",
                table: "Agenda",
                column: "OpeningHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_OpeningPrayerPersonID",
                table: "Agenda",
                column: "OpeningPrayerPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_PresidingPersonID",
                table: "Agenda",
                column: "PresidingPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_SacramentHymnID",
                table: "Agenda",
                column: "SacramentHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Talks_AgendaID",
                table: "Talks",
                column: "AgendaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Talks");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Hymn");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
