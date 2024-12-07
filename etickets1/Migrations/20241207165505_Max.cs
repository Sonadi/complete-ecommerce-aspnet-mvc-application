using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace etickets1.Migrations
{
    /// <inheritdoc />
    public partial class Max : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorrId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieeId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerrId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProducerrId",
                table: "Movies",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "CinemaaId",
                table: "Movies",
                newName: "CinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerrId",
                table: "Movies",
                newName: "IX_Movies_ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaaId",
                table: "Movies",
                newName: "IX_Movies_CinemaId");

            migrationBuilder.RenameColumn(
                name: "MovieeId",
                table: "Actors_Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "ActorrId",
                table: "Actors_Movies",
                newName: "ActorId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieeId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "ProducerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Movies",
                newName: "ProducerrId");

            migrationBuilder.RenameColumn(
                name: "CinemaId",
                table: "Movies",
                newName: "CinemaaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                newName: "IX_Movies_ProducerrId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                newName: "IX_Movies_CinemaaId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Actors_Movies",
                newName: "MovieeId");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors_Movies",
                newName: "ActorrId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorrId",
                table: "Actors_Movies",
                column: "ActorrId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieeId",
                table: "Actors_Movies",
                column: "MovieeId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaaId",
                table: "Movies",
                column: "CinemaaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerrId",
                table: "Movies",
                column: "ProducerrId",
                principalTable: "Producers",
                principalColumn: "ProducerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
