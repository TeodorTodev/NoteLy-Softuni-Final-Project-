using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NoteLy.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "ProfilePicture", "SignUpDate", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, "beyonce@example.com", "Beyoncé", "Knowles-Carter", "PasswordA1!", null, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beyoncé", "Artist" },
                    { 2, "drake@example.com", "Aubrey", "Graham", "PasswordB2!", null, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drake", "Artist" },
                    { 3, "ariana@example.com", "Ariana", "Grande", "PasswordC3!", null, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ArianaGrande", "Artist" },
                    { 4, "eminem@example.com", "Marshall", "Mathers", "PasswordD4!", null, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eminem", "Artist" },
                    { 5, "taylor@example.com", "Taylor", "Swift", "PasswordE5!", null, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "TaylorSwift", "Artist" },
                    { 6, "snoop@example.com", "Calvin", "Broadus Jr.", "PasswordF6!", null, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "SnoopDogg", "Artist" },
                    { 7, "billie@example.com", "Billie", "Eilish", "PasswordG7!", null, new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "BillieEilish", "Artist" },
                    { 8, "rihanna@example.com", "Robyn", "Fenty", "PasswordH8!", null, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rihanna", "Artist" },
                    { 9, "lilnas@example.com", "Montero", "Hill", "PasswordI9!", null, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "LilNasX", "Artist" },
                    { 10, "bruno@example.com", "Peter", "Hernandez", "PasswordJ10!", null, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrunoMars", "Artist" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Indie" },
                    { 2, "Metal" },
                    { 3, "Pop-Folk" },
                    { 4, "Punk" },
                    { 5, "Rap" },
                    { 6, "Salsa" },
                    { 7, "Disco" },
                    { 8, "New Age" },
                    { 9, "Grunge" },
                    { 10, "Opera" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Rock" },
                    { 2, "Pop" },
                    { 3, "Hip Hop" },
                    { 4, "Jazz" },
                    { 5, "Classical" },
                    { 6, "Blues" },
                    { 7, "Electronic" },
                    { 8, "Reggae" },
                    { 9, "Country" },
                    { 10, "R&B" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "ProfilePicture", "SignUpDate", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, "jdoe@example.com", "John", "Doe", "Password123", null, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jdoe", "Regular" },
                    { 2, "asmith@example.com", "Alice", "Smith", "Password456", null, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "asmith", "Regular" },
                    { 3, "bwilliams@example.com", "Bob", "Williams", "Password789", null, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bwilliams", "Regular" },
                    { 4, "clark.kent@example.com", "Clark", "Kent", "Password101", null, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "clark", "Regular" },
                    { 5, "djohnson@example.com", "Diana", "Johnson", "Password102", null, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "djohnson", "Regular" },
                    { 6, "ejames@example.com", "Emma", "James", "Password103", null, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ejames", "Regular" },
                    { 7, "fthompson@example.com", "Fred", "Thompson", "Password104", null, new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "fthompson", "Regular" },
                    { 8, "gmartin@example.com", "Grace", "Martin", "Password105", null, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "gmartin", "Regular" },
                    { 9, "hlee@example.com", "Harry", "Lee", "Password106", null, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "hlee", "Regular" },
                    { 10, "iswanson@example.com", "Ivy", "Swanson", "Password107", null, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "iswanson", "Regular" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "CollectionType", "CoverImage", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, "Album", null, "Renaissance", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "Album", null, "Certified Lover Boy", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, "Album", null, "Positions", new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, "Album", null, "Music to Be Murdered By", new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, "Album", null, "Evermore", new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, "Album", null, "From the Streets 2 the Suites", new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, "Album", null, "Happier Than Ever", new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, "Album", null, "Anti", new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, "Album", null, "Montero", new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, "Album", null, "An Evening with Silk Sonic", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                table: "PlayLists",
                columns: new[] { "Id", "CollectionType", "CreationDate", "Duration", "Name", "Picture", "UserId" },
                values: new object[,]
                {
                    { 1, "Playlist", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Morning Vibes", null, 3 },
                    { 2, "Playlist", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Workout Hits", null, 7 },
                    { 3, "Playlist", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Chill Evenings", null, 2 },
                    { 4, "Playlist", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Top 40", null, 5 },
                    { 5, "Playlist", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Party Time", null, 9 }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumName", "Duration", "FilePath", "Name", "Picture", "PlayListId", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 0, 4, 38, 0), "https://www.youtube.com/watch?v=yjki-9Pthh0", "Break My Soul", null, 5, new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new TimeSpan(0, 0, 3, 45, 0), "https://www.youtube.com/watch?v=WTTHDDT9G5A", "Cuff It", null, 3, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new TimeSpan(0, 0, 1, 56, 0), "https://www.youtube.com/watch?v=FGNs-q4O8yQ", "Energy", null, 2, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new TimeSpan(0, 0, 3, 44, 0), "https://www.youtube.com/watch?v=bZ2wbAt9zH4", "Church Girl", null, 5, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new TimeSpan(0, 0, 6, 8, 0), "https://www.youtube.com/watch?v=0WlYChHJFls", "Virgo's Groove", null, 1, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new TimeSpan(0, 0, 5, 36, 0), "https://www.youtube.com/watch?v=Nj2U6rhnucI", "Champagne Poetry", null, 5, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new TimeSpan(0, 0, 2, 58, 0), "https://www.youtube.com/watch?v=oEDWzbfZnZ8", "Papi's Home", null, 3, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, new TimeSpan(0, 0, 3, 41, 0), "https://www.youtube.com/watch?v=vYdAwfWJx44", "Girls Want Girls", null, 4, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, new TimeSpan(0, 0, 4, 51, 0), "https://www.youtube.com/watch?v=AAz9Sy2qhn0", "Fair Trade", null, 4, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, new TimeSpan(0, 0, 4, 17, 0), "https://www.youtube.com/watch?v=vX9msKu75qs", "Way 2 Sexy", null, 3, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 3, new TimeSpan(0, 0, 2, 52, 0), "https://www.youtube.com/watch?v=tcYodQoapMg", "Positions", null, 1, new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, new TimeSpan(0, 0, 2, 54, 0), "https://www.youtube.com/watch?v=oxXPWzLSsJ4", "34+35", null, 3, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 3, new TimeSpan(0, 0, 2, 47, 0), "https://www.youtube.com/watch?v=i7R4mcc7wzE", "Motive", null, 3, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 3, new TimeSpan(0, 0, 2, 29, 0), "https://www.youtube.com/watch?v=oxKZyMtn7_4", "Just Like Magic", null, 4, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 3, new TimeSpan(0, 0, 3, 59, 0), "https://www.youtube.com/watch?v=tc7USmfQn5w", "Off the Table", null, 2, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 4, new TimeSpan(0, 0, 2, 53, 0), "https://www.youtube.com/watch?v=7h4uUYl-Xrc", "Premonition (Intro)", null, 2, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 4, new TimeSpan(0, 0, 3, 36, 0), "https://www.youtube.com/watch?v=t0O-eY6jc8g", "Unaccommodating", null, 5, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 4, new TimeSpan(0, 0, 3, 55, 0), "https://www.youtube.com/watch?v=xs6YNq5OsHw", "You Gon' Learn", null, 2, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 4, new TimeSpan(0, 0, 2, 57, 0), "https://www.youtube.com/watch?v=frM7Nl84Mkw", "Those Kinda Nights", null, 2, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 4, new TimeSpan(0, 0, 4, 19, 0), "https://www.youtube.com/watch?v=7zsnZ13jG_Q", "In Too Deep", null, 5, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 5, new TimeSpan(0, 0, 5, 4, 0), "https://www.youtube.com/watch?v=pXrfzdNxVXs", "Evermore", null, 4, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 5, new TimeSpan(0, 0, 3, 34, 0), "https://www.youtube.com/watch?v=RsEZmictANA", "Willow", null, 3, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 5, new TimeSpan(0, 0, 4, 4, 0), "https://www.youtube.com/watch?v=wMpqCRF7TKg", "Champagne Problems", null, 1, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 5, new TimeSpan(0, 0, 3, 5, 0), "https://www.youtube.com/watch?v=xam2So8rF6c", "Gold Rush", null, 3, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 5, new TimeSpan(0, 0, 3, 49, 0), "https://www.youtube.com/watch?v=WuvhODoAwSk", "Tis the Damn Season", null, 1, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 6, new TimeSpan(0, 0, 3, 10, 0), "https://www.youtube.com/watch?v=ubGsbhTufuw", "From the Streets 2 the Suites", null, 1, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 6, new TimeSpan(0, 0, 2, 40, 0), "https://www.youtube.com/watch?v=Ernq1ijjPj4", "CEO", null, 5, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 6, new TimeSpan(0, 0, 3, 18, 0), "https://www.youtube.com/watch?v=6RJqgbpnk1U", "Murder Music", null, 3, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 6, new TimeSpan(0, 0, 3, 14, 0), "https://www.youtube.com/watch?v=lRPr3K2lR4A", "Take Me Out the Game", null, 4, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 6, new TimeSpan(0, 0, 2, 43, 0), "https://www.youtube.com/watch?v=vH9q8F_wjM0", "Go Hard 2.0", null, 4, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 7, new TimeSpan(0, 0, 3, 17, 0), "https://www.youtube.com/watch?v=6s6YgKj0c0U", "Getting Older", null, 2, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 7, new TimeSpan(0, 0, 2, 59, 0), "https://www.youtube.com/watch?v=G5Tde5eEIH4", "I Didn't Change My Number", null, 5, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 7, new TimeSpan(0, 0, 3, 19, 0), "https://www.youtube.com/watch?v=fUO9h4bYUpg", "Billie Bossa Nova", null, 3, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 7, new TimeSpan(0, 0, 3, 28, 0), "https://www.youtube.com/watch?v=t0q3PyCXj1Y", "My Future", null, 1, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 7, new TimeSpan(0, 0, 3, 50, 0), "https://www.youtube.com/watch?v=lVfy3FQ8u68", "Oxytocin", null, 1, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 8, new TimeSpan(0, 0, 3, 44, 0), "https://www.youtube.com/watch?v=0RyInjfgNc4", "Love on the Brain", null, 3, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 8, new TimeSpan(0, 0, 4, 14, 0), "https://www.youtube.com/watch?v=E8AdgkJ6cOs", "Kiss It Better", null, 4, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 8, new TimeSpan(0, 0, 3, 9, 0), "https://www.youtube.com/watch?v=wFkkm5QZsR8", "Needed Me", null, 5, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 8, new TimeSpan(0, 0, 3, 18, 0), "https://www.youtube.com/watch?v=mo_xorG9zR8", "Consideration", null, 2, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 8, new TimeSpan(0, 0, 3, 44, 0), "https://www.youtube.com/watch?v=0RyInjfgNc4", "Love on the Brain", null, 2, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 9, new TimeSpan(0, 0, 2, 18, 0), "https://www.youtube.com/watch?v=6kuY4g_Uu1Y", "Montero (Call Me By Your Name)", null, 3, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 9, new TimeSpan(0, 0, 3, 27, 0), "https://www.youtube.com/watch?v=6HjS7fjfyZw", "Industry Baby", null, 5, new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 9, new TimeSpan(0, 0, 3, 36, 0), "https://www.youtube.com/watch?v=R0gq9G3Lx0o", "Scoop", null, 4, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 9, new TimeSpan(0, 0, 3, 32, 0), "https://www.youtube.com/watch?v=3c7b1Z3m_Xg", "Dolla Sign Slime", null, 4, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 9, new TimeSpan(0, 0, 2, 30, 0), "https://www.youtube.com/watch?v=wZPBRxJSFIQ", "Don't Want It All", null, 2, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 10, new TimeSpan(0, 0, 4, 2, 0), "https://www.youtube.com/watch?v=H5X3q6qZjWI", "Leave the Door Open", null, 1, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 10, new TimeSpan(0, 0, 3, 17, 0), "https://www.youtube.com/watch?v=bHgkLa8GZfg", "Fly As Me", null, 5, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 10, new TimeSpan(0, 0, 4, 9, 0), "https://www.youtube.com/watch?v=lG_A9D6DZpE", "After Last Night", null, 3, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 10, new TimeSpan(0, 0, 3, 35, 0), "https://www.youtube.com/watch?v=5XHIFG-6M-c", "Put on a Smile", null, 3, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 10, new TimeSpan(0, 0, 3, 32, 0), "https://www.youtube.com/watch?v=W_E8D8uVVg0", "Love's Train", null, 2, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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
    }
}
