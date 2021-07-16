using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacramento.Migrations
{
    public partial class InitialCreatePlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlanID",
                table: "Person",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MeetingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PresidingLeaderID = table.Column<int>(type: "INTEGER", nullable: false),
                    ConductingLeaderID = table.Column<int>(type: "INTEGER", nullable: false),
                    OpeningSongID = table.Column<int>(type: "INTEGER", nullable: false),
                    OpeningPrayer = table.Column<string>(type: "TEXT", nullable: true),
                    SacramentHymnID = table.Column<int>(type: "INTEGER", nullable: false),
                    IntermediateSongID = table.Column<int>(type: "INTEGER", nullable: false),
                    ClosingSongID = table.Column<int>(type: "INTEGER", nullable: false),
                    ClosingPrayer = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Plan_Hymn_ClosingSongID",
                        column: x => x.ClosingSongID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plan_Hymn_IntermediateSongID",
                        column: x => x.IntermediateSongID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plan_Hymn_OpeningSongID",
                        column: x => x.OpeningSongID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plan_Hymn_SacramentHymnID",
                        column: x => x.SacramentHymnID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plan_Person_ConductingLeaderID",
                        column: x => x.ConductingLeaderID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plan_Person_PresidingLeaderID",
                        column: x => x.PresidingLeaderID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_PlanID",
                table: "Person",
                column: "PlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_ClosingSongID",
                table: "Plan",
                column: "ClosingSongID");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_ConductingLeaderID",
                table: "Plan",
                column: "ConductingLeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_IntermediateSongID",
                table: "Plan",
                column: "IntermediateSongID");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_OpeningSongID",
                table: "Plan",
                column: "OpeningSongID");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_PresidingLeaderID",
                table: "Plan",
                column: "PresidingLeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_SacramentHymnID",
                table: "Plan",
                column: "SacramentHymnID");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Plan_PlanID",
                table: "Person",
                column: "PlanID",
                principalTable: "Plan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Plan_PlanID",
                table: "Person");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropIndex(
                name: "IX_Person_PlanID",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PlanID",
                table: "Person");
        }
    }
}
