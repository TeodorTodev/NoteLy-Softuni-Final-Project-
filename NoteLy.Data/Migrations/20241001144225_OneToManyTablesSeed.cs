using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NoteLy.Data.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyTablesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Id", "ArtistId", "CoverImage", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, null, "Renaissance", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, null, "Certified Lover Boy", new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, null, "Positions", new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, null, "Music to Be Murdered By", new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, null, "Evermore", new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, null, "From the Streets 2 the Suites", new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, null, "Happier Than Ever", new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, null, "Anti", new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, null, "Montero", new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, null, "An Evening with Silk Sonic", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "PlayLists",
                columns: new[] { "Id", "CreationDate", "Duration", "Name", "Picture", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Morning Vibes", null, 3 },
                    { 2, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Workout Hits", null, 7 },
                    { 3, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Chill Evenings", null, 2 },
                    { 4, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Top 40", null, 5 },
                    { 5, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Party Time", null, 9 }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumName", "Duration", "FilePath", "Name", "Picture", "PlayListId", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 0, 4, 38, 0), "https://www.youtube.com/watch?v=yjki-9Pthh0", "Break My Soul", null, null, new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new TimeSpan(0, 0, 3, 45, 0), "https://www.youtube.com/watch?v=WTTHDDT9G5A", "Cuff It", null, null, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new TimeSpan(0, 0, 1, 56, 0), "https://www.youtube.com/watch?v=FGNs-q4O8yQ", "Energy", null, null, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new TimeSpan(0, 0, 3, 44, 0), "https://www.youtube.com/watch?v=bZ2wbAt9zH4", "Church Girl", null, null, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new TimeSpan(0, 0, 6, 8, 0), "https://www.youtube.com/watch?v=0WlYChHJFls", "Virgo's Groove", null, null, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new TimeSpan(0, 0, 5, 36, 0), "https://www.youtube.com/watch?v=Nj2U6rhnucI", "Champagne Poetry", null, null, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new TimeSpan(0, 0, 2, 58, 0), "https://www.youtube.com/watch?v=oEDWzbfZnZ8", "Papi's Home", null, null, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, new TimeSpan(0, 0, 3, 41, 0), "https://www.youtube.com/watch?v=vYdAwfWJx44", "Girls Want Girls", null, null, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, new TimeSpan(0, 0, 4, 51, 0), "https://www.youtube.com/watch?v=AAz9Sy2qhn0", "Fair Trade", null, null, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, new TimeSpan(0, 0, 4, 17, 0), "https://www.youtube.com/watch?v=vX9msKu75qs", "Way 2 Sexy", null, null, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 3, new TimeSpan(0, 0, 2, 52, 0), "https://www.youtube.com/watch?v=tcYodQoapMg", "Positions", null, null, new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, new TimeSpan(0, 0, 2, 54, 0), "https://www.youtube.com/watch?v=oxXPWzLSsJ4", "34+35", null, null, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 3, new TimeSpan(0, 0, 2, 47, 0), "https://www.youtube.com/watch?v=i7R4mcc7wzE", "Motive", null, null, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 3, new TimeSpan(0, 0, 2, 29, 0), "https://www.youtube.com/watch?v=oxKZyMtn7_4", "Just Like Magic", null, null, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 3, new TimeSpan(0, 0, 3, 59, 0), "https://www.youtube.com/watch?v=tc7USmfQn5w", "Off the Table", null, null, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 4, new TimeSpan(0, 0, 2, 53, 0), "https://www.youtube.com/watch?v=7h4uUYl-Xrc", "Premonition (Intro)", null, null, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 4, new TimeSpan(0, 0, 3, 36, 0), "https://www.youtube.com/watch?v=t0O-eY6jc8g", "Unaccommodating", null, null, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 4, new TimeSpan(0, 0, 3, 55, 0), "https://www.youtube.com/watch?v=xs6YNq5OsHw", "You Gon' Learn", null, null, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 4, new TimeSpan(0, 0, 2, 57, 0), "https://www.youtube.com/watch?v=frM7Nl84Mkw", "Those Kinda Nights", null, null, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 4, new TimeSpan(0, 0, 4, 19, 0), "https://www.youtube.com/watch?v=7zsnZ13jG_Q", "In Too Deep", null, null, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 5, new TimeSpan(0, 0, 5, 4, 0), "https://www.youtube.com/watch?v=pXrfzdNxVXs", "Evermore", null, null, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 5, new TimeSpan(0, 0, 3, 34, 0), "https://www.youtube.com/watch?v=RsEZmictANA", "Willow", null, null, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 5, new TimeSpan(0, 0, 4, 4, 0), "https://www.youtube.com/watch?v=wMpqCRF7TKg", "Champagne Problems", null, null, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 5, new TimeSpan(0, 0, 3, 5, 0), "https://www.youtube.com/watch?v=xam2So8rF6c", "Gold Rush", null, null, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 5, new TimeSpan(0, 0, 3, 49, 0), "https://www.youtube.com/watch?v=WuvhODoAwSk", "Tis the Damn Season", null, null, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 6, new TimeSpan(0, 0, 3, 10, 0), "https://www.youtube.com/watch?v=ubGsbhTufuw", "From the Streets 2 the Suites", null, null, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 6, new TimeSpan(0, 0, 2, 40, 0), "https://www.youtube.com/watch?v=Ernq1ijjPj4", "CEO", null, null, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 6, new TimeSpan(0, 0, 3, 18, 0), "https://www.youtube.com/watch?v=6RJqgbpnk1U", "Murder Music", null, null, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 6, new TimeSpan(0, 0, 3, 14, 0), "https://www.youtube.com/watch?v=lRPr3K2lR4A", "Take Me Out the Game", null, null, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 6, new TimeSpan(0, 0, 2, 43, 0), "https://www.youtube.com/watch?v=vH9q8F_wjM0", "Go Hard 2.0", null, null, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 7, new TimeSpan(0, 0, 3, 17, 0), "https://www.youtube.com/watch?v=6s6YgKj0c0U", "Getting Older", null, null, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 7, new TimeSpan(0, 0, 2, 59, 0), "https://www.youtube.com/watch?v=G5Tde5eEIH4", "I Didn't Change My Number", null, null, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 7, new TimeSpan(0, 0, 3, 19, 0), "https://www.youtube.com/watch?v=fUO9h4bYUpg", "Billie Bossa Nova", null, null, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 7, new TimeSpan(0, 0, 3, 28, 0), "https://www.youtube.com/watch?v=t0q3PyCXj1Y", "My Future", null, null, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 7, new TimeSpan(0, 0, 3, 50, 0), "https://www.youtube.com/watch?v=lVfy3FQ8u68", "Oxytocin", null, null, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 8, new TimeSpan(0, 0, 3, 44, 0), "https://www.youtube.com/watch?v=0RyInjfgNc4", "Love on the Brain", null, null, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 8, new TimeSpan(0, 0, 4, 14, 0), "https://www.youtube.com/watch?v=E8AdgkJ6cOs", "Kiss It Better", null, null, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 8, new TimeSpan(0, 0, 3, 9, 0), "https://www.youtube.com/watch?v=wFkkm5QZsR8", "Needed Me", null, null, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 8, new TimeSpan(0, 0, 3, 18, 0), "https://www.youtube.com/watch?v=mo_xorG9zR8", "Consideration", null, null, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 8, new TimeSpan(0, 0, 3, 44, 0), "https://www.youtube.com/watch?v=0RyInjfgNc4", "Love on the Brain", null, null, new DateTime(2016, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 9, new TimeSpan(0, 0, 2, 18, 0), "https://www.youtube.com/watch?v=6kuY4g_Uu1Y", "Montero (Call Me By Your Name)", null, null, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 9, new TimeSpan(0, 0, 3, 27, 0), "https://www.youtube.com/watch?v=6HjS7fjfyZw", "Industry Baby", null, null, new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 9, new TimeSpan(0, 0, 3, 36, 0), "https://www.youtube.com/watch?v=R0gq9G3Lx0o", "Scoop", null, null, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 9, new TimeSpan(0, 0, 3, 32, 0), "https://www.youtube.com/watch?v=3c7b1Z3m_Xg", "Dolla Sign Slime", null, null, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 9, new TimeSpan(0, 0, 2, 30, 0), "https://www.youtube.com/watch?v=wZPBRxJSFIQ", "Don't Want It All", null, null, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 10, new TimeSpan(0, 0, 4, 2, 0), "https://www.youtube.com/watch?v=H5X3q6qZjWI", "Leave the Door Open", null, null, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 10, new TimeSpan(0, 0, 3, 17, 0), "https://www.youtube.com/watch?v=bHgkLa8GZfg", "Fly As Me", null, null, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 10, new TimeSpan(0, 0, 4, 9, 0), "https://www.youtube.com/watch?v=lG_A9D6DZpE", "After Last Night", null, null, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 10, new TimeSpan(0, 0, 3, 35, 0), "https://www.youtube.com/watch?v=5XHIFG-6M-c", "Put on a Smile", null, null, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 10, new TimeSpan(0, 0, 3, 32, 0), "https://www.youtube.com/watch?v=W_E8D8uVVg0", "Love's Train", null, null, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
