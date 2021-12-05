using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class TheWallPicAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://m.media-amazon.com/images/I/8145RpwlT1L._SX355_.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/pinkfloyd/images/f/f5/The_Wall.jpg/revision/latest?cb=20181104235825");
        }
    }
}
