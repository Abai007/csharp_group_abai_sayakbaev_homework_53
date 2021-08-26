using Microsoft.EntityFrameworkCore.Migrations;

namespace homework_51.Migrations
{
    public partial class AddNewP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Phones",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePhone",
                table: "Phones",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "ImagePhone",
                table: "Phones");
        }
    }
}
