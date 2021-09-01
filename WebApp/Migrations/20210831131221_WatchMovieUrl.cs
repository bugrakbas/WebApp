using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class WatchMovieUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WatchMovieUrl",
                table: "TvShow",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WatchMovieUrl",
                table: "TvShow");
        }
    }
}
