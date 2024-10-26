using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteLy.Data.Migrations
{
    /// <inheritdoc />
    public partial class SongIdAddInCommentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Songs_SongId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "SongId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Songs_SongId",
                table: "Comments",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Songs_SongId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "SongId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Songs_SongId",
                table: "Comments",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id");
        }
    }
}
