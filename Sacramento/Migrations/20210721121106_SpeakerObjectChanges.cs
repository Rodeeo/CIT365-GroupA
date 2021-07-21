using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacramento.Migrations
{
    public partial class SpeakerObjectChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Speaker");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Speaker",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Speaker",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Speaker",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
