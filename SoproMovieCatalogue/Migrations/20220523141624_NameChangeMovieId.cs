using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoproMovieCatalogue.Migrations
{
    public partial class NameChangeMovieId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Movies_Movies_MovieId",
                table: "Genres_Movies");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Genres_Movies",
                newName: "MovieId2");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_Movies_MovieId",
                table: "Genres_Movies",
                newName: "IX_Genres_Movies_MovieId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Movies_Movies_MovieId2",
                table: "Genres_Movies",
                column: "MovieId2",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Movies_Movies_MovieId2",
                table: "Genres_Movies");

            migrationBuilder.RenameColumn(
                name: "MovieId2",
                table: "Genres_Movies",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_Movies_MovieId2",
                table: "Genres_Movies",
                newName: "IX_Genres_Movies_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Movies_Movies_MovieId",
                table: "Genres_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
