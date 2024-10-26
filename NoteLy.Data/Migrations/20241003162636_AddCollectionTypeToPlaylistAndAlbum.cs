using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteLy.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCollectionTypeToPlaylistAndAlbum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CollectionType",
                table: "PlayLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CollectionType",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10,
                column: "CollectionType",
                value: "Album");

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CollectionType",
                value: "Playlist");

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CollectionType",
                value: "Playlist");

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 3,
                column: "CollectionType",
                value: "Playlist");

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 4,
                column: "CollectionType",
                value: "Playlist");

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 5,
                column: "CollectionType",
                value: "Playlist");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectionType",
                table: "PlayLists");

            migrationBuilder.DropColumn(
                name: "CollectionType",
                table: "Albums");
        }
    }
}
