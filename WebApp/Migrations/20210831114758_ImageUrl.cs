using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class ImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TvShow",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "TvShow",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,)");

            migrationBuilder.AlterColumn<string>(
                name: "ImdbUrl",
                table: "TvShow",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TvShow",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "TvShow");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TvShow",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "TvShow",
                type: "decimal(18,)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "ImdbUrl",
                table: "TvShow",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
