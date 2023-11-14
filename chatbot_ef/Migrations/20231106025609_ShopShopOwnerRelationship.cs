using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class ShopShopOwnerRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShopOwner_ID",
                table: "Shops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Shops_ShopOwner_ID",
                table: "Shops",
                column: "ShopOwner_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_ShopOwner",
                table: "Shops",
                column: "ShopOwner_ID",
                principalTable: "ShopOwners",
                principalColumn: "ShopOwner_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_ShopOwner",
                table: "Shops");

            migrationBuilder.DropIndex(
                name: "IX_Shops_ShopOwner_ID",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "ShopOwner_ID",
                table: "Shops");
        }
    }
}
