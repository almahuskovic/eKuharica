using Microsoft.EntityFrameworkCore.Migrations;

namespace eKuharica.Migrations
{
    public partial class ArticleTranslations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTranslated",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTranslated",
                table: "Articles");
        }
    }
}
