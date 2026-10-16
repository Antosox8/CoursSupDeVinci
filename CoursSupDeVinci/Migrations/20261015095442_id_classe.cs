using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursSupDeVinci.Migrations
{
    /// <inheritdoc />
    public partial class id_classe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_person_classes_IdClasse",
                table: "person");

            migrationBuilder.RenameColumn(
                name: "IdClasse",
                table: "person",
                newName: "id_classe");

            migrationBuilder.RenameIndex(
                name: "IX_person_IdClasse",
                table: "person",
                newName: "IX_person_id_classe");

            migrationBuilder.AddForeignKey(
                name: "FK_person_classes_id_classe",
                table: "person",
                column: "id_classe",
                principalTable: "classes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_person_classes_id_classe",
                table: "person");

            migrationBuilder.RenameColumn(
                name: "id_classe",
                table: "person",
                newName: "IdClasse");

            migrationBuilder.RenameIndex(
                name: "IX_person_id_classe",
                table: "person",
                newName: "IX_person_IdClasse");

            migrationBuilder.AddForeignKey(
                name: "FK_person_classes_IdClasse",
                table: "person",
                column: "IdClasse",
                principalTable: "classes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
