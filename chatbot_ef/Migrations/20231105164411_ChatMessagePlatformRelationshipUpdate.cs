using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class ChatMessagePlatformRelationshipUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Platform_ID",
                table: "ChatMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_Platform_ID",
                table: "ChatMessages",
                column: "Platform_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_Platform",
                table: "ChatMessages",
                column: "Platform_ID",
                principalTable: "Platforms",
                principalColumn: "Platform_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_Platform",
                table: "ChatMessages");

            migrationBuilder.DropIndex(
                name: "IX_ChatMessages_Platform_ID",
                table: "ChatMessages");

            migrationBuilder.DropColumn(
                name: "Platform_ID",
                table: "ChatMessages");
        }
    }
}
