using Microsoft.EntityFrameworkCore.Migrations;

namespace e_tuition2021.Migrations
{
    public partial class AddLessonsToTutors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TutorPersonId",
                table: "Lessons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_TutorPersonId",
                table: "Lessons",
                column: "TutorPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_People_TutorPersonId",
                table: "Lessons",
                column: "TutorPersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_People_TutorPersonId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_TutorPersonId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "TutorPersonId",
                table: "Lessons");
        }
    }
}
