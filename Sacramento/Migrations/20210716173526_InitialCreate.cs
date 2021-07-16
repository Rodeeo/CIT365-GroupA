using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacramento.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Leader",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CallDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leader", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PresidingLeaderID = table.Column<int>(type: "int", nullable: false),
                    ConductingLeaderID = table.Column<int>(type: "int", nullable: false),
                    OpeningSongID = table.Column<int>(type: "int", nullable: false),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentHymnID = table.Column<int>(type: "int", nullable: false),
                    IntermediateSongID = table.Column<int>(type: "int", nullable: false),
                    ClosingSongID = table.Column<int>(type: "int", nullable: false),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Plan_Hymn_ClosingSongID",
                        column: x => x.ClosingSongID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Plan_Hymn_IntermediateSongID",
                        column: x => x.IntermediateSongID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Plan_Hymn_OpeningSongID",
                        column: x => x.OpeningSongID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Plan_Hymn_SacramentHymnID",
                        column: x => x.SacramentHymnID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Plan_Leader_ConductingLeaderID",
                        column: x => x.ConductingLeaderID,
                        principalTable: "Leader",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Plan_Leader_PresidingLeaderID",
                        column: x => x.PresidingLeaderID,
                        principalTable: "Leader",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Speaker_Plan_PlanID",
                        column: x => x.PlanID,
                        principalTable: "Plan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_PlanID",
                table: "Speaker",
                column: "PlanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Hymn");

            migrationBuilder.DropTable(
                name: "Leader");
        }
    }
}
