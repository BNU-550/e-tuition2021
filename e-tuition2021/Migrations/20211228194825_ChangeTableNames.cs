using Microsoft.EntityFrameworkCore.Migrations;

namespace e_tuition2021.Migrations
{
    public partial class ChangeTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_TimeSlot_TimeSlotId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlot_People_TutorId",
                table: "TimeSlot");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeSlot",
                table: "TimeSlot");

            migrationBuilder.RenameTable(
                name: "TimeSlot",
                newName: "TimeSlots");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSlot_TutorId",
                table: "TimeSlots",
                newName: "IX_TimeSlots_TutorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeSlots",
                table: "TimeSlots",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_TimeSlots_TimeSlotId",
                table: "Lessons",
                column: "TimeSlotId",
                principalTable: "TimeSlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlots_People_TutorId",
                table: "TimeSlots",
                column: "TutorId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_TimeSlots_TimeSlotId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlots_People_TutorId",
                table: "TimeSlots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeSlots",
                table: "TimeSlots");

            migrationBuilder.RenameTable(
                name: "TimeSlots",
                newName: "TimeSlot");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSlots_TutorId",
                table: "TimeSlot",
                newName: "IX_TimeSlot_TutorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeSlot",
                table: "TimeSlot",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_TimeSlot_TimeSlotId",
                table: "Lessons",
                column: "TimeSlotId",
                principalTable: "TimeSlot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlot_People_TutorId",
                table: "TimeSlot",
                column: "TutorId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
