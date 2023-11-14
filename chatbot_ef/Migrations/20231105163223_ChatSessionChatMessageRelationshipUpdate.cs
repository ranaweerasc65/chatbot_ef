using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class ChatSessionChatMessageRelationshipUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Session_ID",
                table: "ChatMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_Session_ID",
                table: "ChatMessages",
                column: "Session_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_ChatSession",
                table: "ChatMessages",
                column: "Session_ID",
                principalTable: "ChatSessions",
                principalColumn: "Session_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_ChatSession",
                table: "ChatMessages");

            migrationBuilder.DropIndex(
                name: "IX_ChatMessages_Session_ID",
                table: "ChatMessages");

            migrationBuilder.DropColumn(
                name: "Session_ID",
                table: "ChatMessages");
        }
    }
}
