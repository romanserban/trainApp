using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Reservation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Car",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "SeatNumber",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "Train",
                table: "Reservations",
                newName: "SeatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeatId",
                table: "Reservations",
                newName: "Train");

            migrationBuilder.AddColumn<int>(
                name: "Car",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeatNumber",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
