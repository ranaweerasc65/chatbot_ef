using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class AddShopOwnerToChatSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChatSessionId",
                table: "ShopOwners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShopOwners_ChatSessionId",
                table: "ShopOwners",
                column: "ChatSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopOwners_ChatSessions_ChatSessionId",
                table: "ShopOwners",
                column: "ChatSessionId",
                principalTable: "ChatSessions",
                principalColumn: "Session_ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopOwners_ChatSessions_ChatSessionId",
                table: "ShopOwners");

            migrationBuilder.DropIndex(
                name: "IX_ShopOwners_ChatSessionId",
                table: "ShopOwners");

            migrationBuilder.DropColumn(
                name: "ChatSessionId",
                table: "ShopOwners");
        }
    }
}
