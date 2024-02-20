using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP06EFC.Migrations
{
    /// <inheritdoc />
    public partial class Subjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "ClassroomSubject",
                columns: table => new
                {
                    ClassroomsClassroomId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjectsSubjectId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassroomSubject", x => new { x.ClassroomsClassroomId, x.SubjectsSubjectId });
                    table.ForeignKey(
                        name: "FK_ClassroomSubject_Classrooms_ClassroomsClassroomId",
                        column: x => x.ClassroomsClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "ClassroomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassroomSubject_Subjects_SubjectsSubjectId",
                        column: x => x.SubjectsSubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Name" },
                values: new object[,]
                {
                    { 1, "Matematika" },
                    { 2, "Český jazyk" },
                    { 3, "Anglický jazyk" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassroomSubject_SubjectsSubjectId",
                table: "ClassroomSubject",
                column: "SubjectsSubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassroomSubject");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
