using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Platforms_Platform_ID1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Platform_ID1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Platform_ID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Platform_ID1",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "Platform_ID",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Platform_ID1",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Platform_ID1",
                table: "Customers",
                column: "Platform_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Platforms_Platform_ID1",
                table: "Customers",
                column: "Platform_ID1",
                principalTable: "Platforms",
                principalColumn: "Platform_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
