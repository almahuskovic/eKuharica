using Microsoft.EntityFrameworkCore.Migrations;

namespace eKuharica.Migrations
{
    public partial class removeFieldContentInRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Recipes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
