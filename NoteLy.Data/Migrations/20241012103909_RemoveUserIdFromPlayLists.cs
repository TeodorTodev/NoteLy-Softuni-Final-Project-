using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteLy.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserIdFromPlayLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayLists_Users_UserId",
                table: "PlayLists");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PlayLists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayLists_Users_UserId",
                table: "PlayLists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayLists_Users_UserId",
                table: "PlayLists");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PlayLists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayLists_Users_UserId",
                table: "PlayLists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
