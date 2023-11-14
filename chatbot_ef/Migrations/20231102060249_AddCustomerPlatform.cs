using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerPlatform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_Customer_ID",
                table: "Appointments");

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

            migrationBuilder.AlterColumn<int>(
                name: "Customer_ID",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Platform_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Platform_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerPlatform",
                columns: table => new
                {
                    CustomerPlatform_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Platform_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPlatform", x => x.CustomerPlatform_ID);
                    table.ForeignKey(
                        name: "FK_CustomerPlatform_Customers_Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerPlatform_Platforms_Platform_ID",
                        column: x => x.Platform_ID,
                        principalTable: "Platforms",
                        principalColumn: "Platform_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Platform_ID1",
                table: "Customers",
                column: "Platform_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPlatform_Customer_ID",
                table: "CustomerPlatform",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPlatform_Platform_ID",
                table: "CustomerPlatform",
                column: "Platform_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_Customer_ID",
                table: "Appointments",
                column: "Customer_ID",
                principalTable: "Customers",
                principalColumn: "Customer_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Platforms_Platform_ID1",
                table: "Customers",
                column: "Platform_ID1",
                principalTable: "Platforms",
                principalColumn: "Platform_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_Customer_ID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Platforms_Platform_ID1",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "CustomerPlatform");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Platform_ID1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Platform_ID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Platform_ID1",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "Customer_ID",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_Customer_ID",
                table: "Appointments",
                column: "Customer_ID",
                principalTable: "Customers",
                principalColumn: "Customer_ID");
        }
    }
}
