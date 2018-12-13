using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizGame.Data.Migrations
{
    public partial class AddedLinkingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AspNetUsers_QuizGameUserId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuizGameUserId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuizGameUserId",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.UserId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_Likes_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_QuestionId",
                table: "Likes",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.AddColumn<string>(
                name: "QuizGameUserId",
                table: "Questions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizGameUserId",
                table: "Questions",
                column: "QuizGameUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AspNetUsers_QuizGameUserId",
                table: "Questions",
                column: "QuizGameUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
