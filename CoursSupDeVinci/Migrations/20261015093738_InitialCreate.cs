using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursSupDeVinci.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    level = table.Column<string>(type: "text", nullable: false),
                    school = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "detail",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    street = table.Column<string>(type: "text", nullable: false),
                    zipcode = table.Column<string>(type: "text", nullable: false),
                    city = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdClasse = table.Column<Guid>(type: "uuid", nullable: false),
                    firstname = table.Column<string>(type: "text", nullable: false),
                    lastname = table.Column<string>(type: "text", nullable: false),
                    birthdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    size = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.id);
                    table.ForeignKey(
                        name: "FK_person_classes_IdClasse",
                        column: x => x.IdClasse,
                        principalTable: "classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "person_detail",
                columns: table => new
                {
                    id_detail = table.Column<Guid>(type: "uuid", nullable: false),
                    id_person = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person_detail", x => new { x.id_detail, x.id_person });
                    table.ForeignKey(
                        name: "FK_person_detail_detail_id_detail",
                        column: x => x.id_detail,
                        principalTable: "detail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_person_detail_person_id_person",
                        column: x => x.id_person,
                        principalTable: "person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_person_IdClasse",
                table: "person",
                column: "IdClasse");

            migrationBuilder.CreateIndex(
                name: "IX_person_detail_id_person",
                table: "person_detail",
                column: "id_person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "person_detail");

            migrationBuilder.DropTable(
                name: "detail");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "classes");
        }
    }
}
