using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NoteLy.Data.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyTablesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 4, 18 },
                    { 4, 19 },
                    { 4, 20 },
                    { 5, 21 },
                    { 5, 22 },
                    { 5, 23 },
                    { 5, 24 },
                    { 5, 25 },
                    { 6, 26 },
                    { 6, 27 },
                    { 6, 28 },
                    { 6, 29 },
                    { 6, 30 },
                    { 7, 31 },
                    { 7, 32 },
                    { 7, 33 },
                    { 7, 34 },
                    { 7, 35 },
                    { 8, 36 },
                    { 8, 37 },
                    { 8, 38 },
                    { 8, 39 },
                    { 8, 40 },
                    { 9, 41 },
                    { 9, 42 },
                    { 9, 43 },
                    { 9, 44 },
                    { 9, 45 },
                    { 10, 46 },
                    { 10, 47 },
                    { 10, 48 },
                    { 10, 49 },
                    { 10, 50 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "SongId", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Absolutely love this track!", 1 },
                    { 2, 1, "This song is amazing!", 2 },
                    { 3, 2, "Incredible vibe!", 3 },
                    { 4, 2, "One of my favorites!", 4 },
                    { 5, 3, "Such a great melody!", 5 },
                    { 6, 3, "I can't stop listening to this!", 6 },
                    { 7, 4, "This is pure gold!", 7 },
                    { 8, 4, "Really well produced!", 8 },
                    { 9, 5, "So catchy!", 9 },
                    { 10, 5, "Amazing lyrics!", 10 },
                    { 11, 6, "Absolutely love this track!", 1 },
                    { 12, 6, "This song is amazing!", 2 },
                    { 13, 7, "Incredible vibe!", 3 },
                    { 14, 7, "One of my favorites!", 4 },
                    { 15, 8, "Such a great melody!", 5 },
                    { 16, 8, "I can't stop listening to this!", 6 },
                    { 17, 9, "This is pure gold!", 7 },
                    { 18, 9, "Really well produced!", 8 },
                    { 19, 10, "So catchy!", 9 },
                    { 20, 10, "Amazing lyrics!", 10 },
                    { 21, 11, "Absolutely love this track!", 1 },
                    { 22, 11, "This song is amazing!", 2 },
                    { 23, 12, "Incredible vibe!", 3 },
                    { 24, 12, "One of my favorites!", 4 },
                    { 25, 13, "Such a great melody!", 5 },
                    { 26, 13, "I can't stop listening to this!", 6 },
                    { 27, 14, "This is pure gold!", 7 },
                    { 28, 14, "Really well produced!", 8 },
                    { 29, 15, "So catchy!", 9 },
                    { 30, 15, "Amazing lyrics!", 10 },
                    { 31, 16, "Absolutely love this track!", 1 },
                    { 32, 16, "This song is amazing!", 2 },
                    { 33, 17, "Incredible vibe!", 3 },
                    { 34, 17, "One of my favorites!", 4 },
                    { 35, 18, "Such a great melody!", 5 },
                    { 36, 18, "I can't stop listening to this!", 6 },
                    { 37, 19, "This is pure gold!", 7 },
                    { 38, 19, "Really well produced!", 8 },
                    { 39, 20, "So catchy!", 9 },
                    { 40, 20, "Amazing lyrics!", 10 },
                    { 41, 21, "Absolutely love this track!", 1 },
                    { 42, 21, "This song is amazing!", 2 },
                    { 43, 22, "Incredible vibe!", 3 },
                    { 44, 22, "One of my favorites!", 4 },
                    { 45, 23, "Such a great melody!", 5 },
                    { 46, 23, "I can't stop listening to this!", 6 },
                    { 47, 24, "This is pure gold!", 7 },
                    { 48, 24, "Really well produced!", 8 },
                    { 49, 25, "So catchy!", 9 },
                    { 50, 25, "Amazing lyrics!", 10 },
                    { 51, 26, "Absolutely love this track!", 1 },
                    { 52, 26, "This song is amazing!", 2 },
                    { 53, 27, "Incredible vibe!", 3 },
                    { 54, 27, "One of my favorites!", 4 },
                    { 55, 28, "Such a great melody!", 5 },
                    { 56, 28, "I can't stop listening to this!", 6 },
                    { 57, 29, "This is pure gold!", 7 },
                    { 58, 29, "Really well produced!", 8 },
                    { 59, 30, "So catchy!", 9 },
                    { 60, 30, "Amazing lyrics!", 10 },
                    { 61, 31, "Absolutely love this track!", 1 },
                    { 62, 31, "This song is amazing!", 2 },
                    { 63, 32, "Incredible vibe!", 3 },
                    { 64, 32, "One of my favorites!", 4 },
                    { 65, 33, "Such a great melody!", 5 },
                    { 66, 33, "I can't stop listening to this!", 6 },
                    { 67, 34, "This is pure gold!", 7 },
                    { 68, 34, "Really well produced!", 8 },
                    { 69, 35, "So catchy!", 9 },
                    { 70, 35, "Amazing lyrics!", 10 },
                    { 71, 36, "Absolutely love this track!", 1 },
                    { 72, 36, "This song is amazing!", 2 },
                    { 73, 37, "Incredible vibe!", 3 },
                    { 74, 37, "One of my favorites!", 4 },
                    { 75, 38, "Such a great melody!", 5 },
                    { 76, 38, "I can't stop listening to this!", 6 },
                    { 77, 39, "This is pure gold!", 7 },
                    { 78, 39, "Really well produced!", 8 },
                    { 79, 40, "So catchy!", 9 },
                    { 80, 40, "Amazing lyrics!", 10 },
                    { 81, 41, "Absolutely love this track!", 1 },
                    { 82, 41, "This song is amazing!", 2 },
                    { 83, 42, "Incredible vibe!", 3 },
                    { 84, 42, "One of my favorites!", 4 },
                    { 85, 43, "Such a great melody!", 5 },
                    { 86, 43, "I can't stop listening to this!", 6 },
                    { 87, 44, "This is pure gold!", 7 },
                    { 88, 44, "Really well produced!", 8 },
                    { 89, 45, "So catchy!", 9 },
                    { 90, 45, "Amazing lyrics!", 10 },
                    { 91, 46, "Absolutely love this track!", 1 },
                    { 92, 46, "This song is amazing!", 2 },
                    { 93, 47, "Incredible vibe!", 3 },
                    { 94, 47, "One of my favorites!", 4 },
                    { 95, 48, "Such a great melody!", 5 },
                    { 96, 48, "I can't stop listening to this!", 6 },
                    { 97, 49, "This is pure gold!", 7 },
                    { 98, 49, "Really well produced!", 8 },
                    { 99, 50, "So catchy!", 9 },
                    { 100, 50, "Amazing lyrics!", 10 }
                });

            migrationBuilder.InsertData(
                table: "Followers",
                columns: new[] { "ArtistId", "UserId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 8, 3 },
                    { 5, 4 },
                    { 3, 5 },
                    { 9, 6 },
                    { 10, 7 },
                    { 6, 8 },
                    { 4, 9 },
                    { 7, 10 }
                });

            migrationBuilder.InsertData(
                table: "SongGenres",
                columns: new[] { "GenreId", "SongId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 7, 2 },
                    { 1, 3 },
                    { 3, 4 },
                    { 10, 5 },
                    { 6, 6 },
                    { 9, 7 },
                    { 5, 8 },
                    { 2, 9 },
                    { 8, 10 },
                    { 4, 11 },
                    { 10, 12 },
                    { 1, 13 },
                    { 7, 14 },
                    { 6, 15 },
                    { 2, 16 },
                    { 8, 17 },
                    { 3, 18 },
                    { 5, 19 },
                    { 9, 20 },
                    { 10, 21 },
                    { 1, 22 },
                    { 4, 23 },
                    { 7, 24 },
                    { 6, 25 },
                    { 8, 26 },
                    { 2, 27 },
                    { 5, 28 },
                    { 9, 29 },
                    { 3, 30 },
                    { 10, 31 },
                    { 6, 32 },
                    { 1, 33 },
                    { 7, 34 },
                    { 2, 35 },
                    { 4, 36 },
                    { 8, 37 },
                    { 3, 38 },
                    { 5, 39 },
                    { 9, 40 },
                    { 10, 41 },
                    { 1, 42 },
                    { 6, 43 },
                    { 2, 44 },
                    { 4, 45 },
                    { 8, 46 },
                    { 3, 47 },
                    { 5, 48 },
                    { 9, 49 },
                    { 10, 50 }
                });

            migrationBuilder.InsertData(
                table: "TagSongs",
                columns: new[] { "SongId", "TagId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 7 },
                    { 3, 1 },
                    { 4, 3 },
                    { 5, 10 },
                    { 6, 6 },
                    { 7, 9 },
                    { 8, 5 },
                    { 9, 2 },
                    { 10, 8 },
                    { 11, 4 },
                    { 12, 10 },
                    { 13, 1 },
                    { 14, 7 },
                    { 15, 6 },
                    { 16, 2 },
                    { 17, 8 },
                    { 18, 3 },
                    { 19, 5 },
                    { 20, 9 },
                    { 21, 10 },
                    { 22, 1 },
                    { 23, 4 },
                    { 24, 7 },
                    { 25, 6 },
                    { 26, 8 },
                    { 27, 2 },
                    { 28, 5 },
                    { 29, 9 },
                    { 30, 3 },
                    { 31, 10 },
                    { 32, 6 },
                    { 33, 1 },
                    { 34, 7 },
                    { 35, 2 },
                    { 36, 4 },
                    { 37, 8 },
                    { 38, 3 },
                    { 39, 5 },
                    { 40, 9 },
                    { 41, 10 },
                    { 42, 1 },
                    { 43, 6 },
                    { 44, 2 },
                    { 45, 4 },
                    { 46, 8 },
                    { 47, 3 },
                    { 48, 5 },
                    { 49, 9 },
                    { 50, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 5, 21 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 5, 24 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 5, 25 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 6, 26 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 6, 27 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 6, 28 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 6, 29 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 6, 30 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 7, 31 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 7, 32 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 7, 33 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 7, 34 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 7, 35 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 8, 36 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 8, 37 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 8, 38 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 8, 39 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 8, 40 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 9, 41 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 9, 42 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 9, 43 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 9, 44 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 9, 45 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 10, 46 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 10, 47 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 10, 48 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 10, 49 });

            migrationBuilder.DeleteData(
                table: "ArtistSongs",
                keyColumns: new[] { "ArtistId", "SongId" },
                keyValues: new object[] { 10, 50 });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumns: new[] { "ArtistId", "UserId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 6, 25 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 8, 26 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 2, 27 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 5, 28 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 9, 29 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 10, 31 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 6, 32 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 7, 34 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 2, 35 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 4, 36 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 8, 37 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 3, 38 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 5, 39 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 9, 40 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 10, 41 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 6, 43 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 2, 44 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 4, 45 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 8, 46 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 3, 47 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 5, 48 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 9, 49 });

            migrationBuilder.DeleteData(
                table: "SongGenres",
                keyColumns: new[] { "GenreId", "SongId" },
                keyValues: new object[] { 10, 50 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 20, 9 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 26, 8 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 31, 10 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 36, 4 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 37, 8 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 38, 3 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 40, 9 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 41, 10 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 43, 6 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 44, 2 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 45, 4 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 46, 8 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 47, 3 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 48, 5 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 49, 9 });

            migrationBuilder.DeleteData(
                table: "TagSongs",
                keyColumns: new[] { "SongId", "TagId" },
                keyValues: new object[] { 50, 10 });
        }
    }
}
