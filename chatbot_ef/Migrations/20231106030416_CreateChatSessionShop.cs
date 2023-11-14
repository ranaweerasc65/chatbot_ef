using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class CreateChatSessionShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatSessionShop",
                columns: table => new
                {
                    ChatSessionId = table.Column<int>(type: "int", nullable: false),
                    Shop_Id = table.Column<int>(type: "int", nullable: false),
                    ChatSessionShopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatSessionShop", x => new { x.ChatSessionId, x.Shop_Id });
                    table.ForeignKey(
                        name: "FK_ChatSessionShop_ChatSessions_ChatSessionId",
                        column: x => x.ChatSessionId,
                        principalTable: "ChatSessions",
                        principalColumn: "Session_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatSessionShop_Shops_Shop_Id",
                        column: x => x.Shop_Id,
                        principalTable: "Shops",
                        principalColumn: "Shop_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ChatSessionShop_Shop_Id",
                table: "ChatSessionShop",
                column: "Shop_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatSessionShop");
        }
    }
}
