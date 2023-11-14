using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductCategoryRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category_ID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_ID",
                table: "Products",
                column: "Category_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category",
                table: "Products",
                column: "Category_ID",
                principalTable: "Categories",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Category_ID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Category_ID",
                table: "Products");
        }
    }
}
