using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Reservation6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Reservations_Reservationid",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_Reservationid",
                table: "Seats");

            migrationBuilder.AlterColumn<int>(
                name: "Reservationid",
                table: "Seats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "seatId",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "seatId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "Reservationid",
                table: "Seats",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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
    }
}
