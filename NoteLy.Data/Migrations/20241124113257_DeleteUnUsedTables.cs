using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteLy.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeleteUnUsedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SongGenres_Genres_GenreId",
                table: "SongGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_SongGenres_Songs_SongId",
                table: "SongGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_TagSongs_Songs_SongId",
                table: "TagSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_TagSongs_Tags_TagId",
                table: "TagSongs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagSongs",
                table: "TagSongs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SongGenres",
                table: "SongGenres");

            migrationBuilder.DropIndex(
                name: "IX_SongGenres_GenreId",
                table: "SongGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "TagSongs",
                newName: "TagSong");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "SongGenres",
                newName: "SongGenre");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameIndex(
                name: "IX_TagSongs_TagId",
                table: "TagSong",
                newName: "IX_TagSong_TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagSong",
                table: "TagSong",
                columns: new[] { "SongId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SongGenre",
                table: "SongGenre",
                columns: new[] { "GenreId", "SongId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SongGenre_SongId",
                table: "SongGenre",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_SongGenre_Genre_GenreId",
                table: "SongGenre",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SongGenre_Songs_SongId",
                table: "SongGenre",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagSong_Songs_SongId",
                table: "TagSong",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagSong_Tag_TagId",
                table: "TagSong",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SongGenre_Genre_GenreId",
                table: "SongGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_SongGenre_Songs_SongId",
                table: "SongGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_TagSong_Songs_SongId",
                table: "TagSong");

            migrationBuilder.DropForeignKey(
                name: "FK_TagSong_Tag_TagId",
                table: "TagSong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagSong",
                table: "TagSong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SongGenre",
                table: "SongGenre");

            migrationBuilder.DropIndex(
                name: "IX_SongGenre_SongId",
                table: "SongGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.RenameTable(
                name: "TagSong",
                newName: "TagSongs");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "SongGenre",
                newName: "SongGenres");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameIndex(
                name: "IX_TagSong_TagId",
                table: "TagSongs",
                newName: "IX_TagSongs_TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagSongs",
                table: "TagSongs",
                columns: new[] { "SongId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SongGenres",
                table: "SongGenres",
                columns: new[] { "SongId", "GenreId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SongGenres_GenreId",
                table: "SongGenres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_SongGenres_Genres_GenreId",
                table: "SongGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SongGenres_Songs_SongId",
                table: "SongGenres",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagSongs_Songs_SongId",
                table: "TagSongs",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagSongs_Tags_TagId",
                table: "TagSongs",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
