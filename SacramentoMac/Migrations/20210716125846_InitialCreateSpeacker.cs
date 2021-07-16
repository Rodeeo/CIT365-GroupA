using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacramento.Migrations
{
    public partial class InitialCreateSpeacker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Person",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Person");
        }
    }
}
