using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteLy.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeEntityConfigurationsDeleteBehaviorsToNoAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistSongs_Songs_SongId",
                table: "ArtistSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_PlayLists_PlayListId",
                table: "Songs");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistSongs_Songs_SongId",
                table: "ArtistSongs",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_PlayLists_PlayListId",
                table: "Songs",
                column: "PlayListId",
                principalTable: "PlayLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistSongs_Songs_SongId",
                table: "ArtistSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_PlayLists_PlayListId",
                table: "Songs");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistSongs_Songs_SongId",
                table: "ArtistSongs",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_PlayLists_PlayListId",
                table: "Songs",
                column: "PlayListId",
                principalTable: "PlayLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
