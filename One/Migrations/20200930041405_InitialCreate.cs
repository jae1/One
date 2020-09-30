using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace One.Migrations
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
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RoastLevel = table.Column<string>(nullable: true),
                    Taste = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    CoffeeName = table.Column<string>(nullable: true),
                    RoastDate = table.Column<DateTime>(nullable: false)
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
