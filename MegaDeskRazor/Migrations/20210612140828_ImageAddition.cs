using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskRazor.Migrations
{
    public partial class ImageAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "DesktopMaterial");

            migrationBuilder.AddColumn<int>(
                name: "ImageID",
                table: "DesktopMaterial",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Path = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DesktopMaterial_ImageID",
                table: "DesktopMaterial",
                column: "ImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_DesktopMaterial_Image_ImageID",
                table: "DesktopMaterial",
                column: "ImageID",
                principalTable: "Image",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesktopMaterial_Image_ImageID",
                table: "DesktopMaterial");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropIndex(
                name: "IX_DesktopMaterial_ImageID",
                table: "DesktopMaterial");

            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "DesktopMaterial");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "DesktopMaterial",
                type: "TEXT",
                nullable: true);
        }
    }
}
