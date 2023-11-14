using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class AddChatSessionCustomerRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "ChatSessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChatSessions_CustomerId",
                table: "ChatSessions",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatSession_Customer",
                table: "ChatSessions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Customer_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatSession_Customer",
                table: "ChatSessions");

            migrationBuilder.DropIndex(
                name: "IX_ChatSessions_CustomerId",
                table: "ChatSessions");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ChatSessions");
        }
    }
}
