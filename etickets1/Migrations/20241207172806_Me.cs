using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace etickets1.Migrations
{
    /// <inheritdoc />
    public partial class Me : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actors",
                newName: "ActorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors",
                newName: "Id");
        }
    }
}
