using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacramento.Migrations
{
    public partial class NullableIntermediateSong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Hymn_IntermediateSongID",
                table: "Plan");

            migrationBuilder.AlterColumn<int>(
                name: "IntermediateSongID",
                table: "Plan",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Hymn_IntermediateSongID",
                table: "Plan",
                column: "IntermediateSongID",
                principalTable: "Hymn",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Hymn_IntermediateSongID",
                table: "Plan");

            migrationBuilder.AlterColumn<int>(
                name: "IntermediateSongID",
                table: "Plan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Hymn_IntermediateSongID",
                table: "Plan",
                column: "IntermediateSongID",
                principalTable: "Hymn",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
