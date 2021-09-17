using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Reservation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "Reservationid",
                table: "Seats",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_Reservationid",
                table: "Seats",
                column: "Reservationid");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Reservations_Reservationid",
                table: "Seats",
                column: "Reservationid",
                principalTable: "Reservations",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Reservations_Reservationid",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_Reservationid",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "Reservationid",
                table: "Seats");

            migrationBuilder.AddColumn<int>(
                name: "SeatId",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
