using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeShop.Migrations
{
    public partial class CreateCoffeeShopDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Over18",
                table: "Users",
                newName: "HadCoffee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HadCoffee",
                table: "Users",
                newName: "Over18");
        }
    }
}
