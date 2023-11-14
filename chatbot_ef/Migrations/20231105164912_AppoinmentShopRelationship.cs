using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatbot_ef.Migrations
{
    /// <inheritdoc />
    public partial class AppoinmentShopRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Shop_Id",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Shop_Id",
                table: "Appointments",
                column: "Shop_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Shop",
                table: "Appointments",
                column: "Shop_Id",
                principalTable: "Shops",
                principalColumn: "Shop_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Shop",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_Shop_Id",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Shop_Id",
                table: "Appointments");
        }
    }
}
