using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffee_Culture.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Coffee",
                table: "Coffee");

            migrationBuilder.RenameTable(
                name: "Coffee",
                newName: "CoffeeBean");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "CoffeeBean",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoffeeBean",
                table: "CoffeeBean",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CoffeeBean",
                table: "CoffeeBean");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "CoffeeBean");

            migrationBuilder.RenameTable(
                name: "CoffeeBean",
                newName: "Coffee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coffee",
                table: "Coffee",
                column: "Id");
        }
    }
}
