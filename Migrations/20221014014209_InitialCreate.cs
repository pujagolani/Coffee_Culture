using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffee_Culture.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coffee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Types_Of_Coffee = table.Column<string>(nullable: true),
                    Manufacture_Date = table.Column<DateTime>(nullable: false),
                    Production_Country = table.Column<string>(nullable: true),
                    Roasting = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description_Of_Product = table.Column<string>(nullable: true),
                    Packaging = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coffee");
        }
    }
}
