using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Customer_ID",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Customer_ID",
                table: "Appointments",
                column: "Customer_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_Customer_ID",
                table: "Appointments",
                column: "Customer_ID",
                principalTable: "Customers",
                principalColumn: "Customer_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_Customer_ID",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_Customer_ID",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Customer_ID",
                table: "Appointments");
        }
    }
}
