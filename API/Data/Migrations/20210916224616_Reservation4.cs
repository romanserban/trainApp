using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Reservation4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Reservations_Reservationid",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Reservations_Reservationid",
                table: "Seats",
                column: "Reservationid",
                principalTable: "Reservations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Reservations_Reservationid",
                table: "Seats");

            migrationBuilder.AlterColumn<int>(
                name: "Reservationid",
                table: "Seats",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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
