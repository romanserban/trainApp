using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Trains_Trainid",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Cars_Carid",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "CarType",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Trainid",
                table: "Cars",
                newName: "TrainId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_Trainid",
                table: "Cars",
                newName: "IX_Cars_TrainId");

            migrationBuilder.AlterColumn<string>(
                name: "DayOfTheWeek",
                table: "Trains",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Carid",
                table: "Seats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrainId",
                table: "Cars",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Trains_TrainId",
                table: "Cars",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Cars_Carid",
                table: "Seats",
                column: "Carid",
                principalTable: "Cars",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Trains_TrainId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Cars_Carid",
                table: "Seats");

            migrationBuilder.RenameColumn(
                name: "TrainId",
                table: "Cars",
                newName: "Trainid");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_TrainId",
                table: "Cars",
                newName: "IX_Cars_Trainid");

            migrationBuilder.AlterColumn<int>(
                name: "DayOfTheWeek",
                table: "Trains",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Carid",
                table: "Seats",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Trainid",
                table: "Cars",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "CarType",
                table: "Cars",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Trains_Trainid",
                table: "Cars",
                column: "Trainid",
                principalTable: "Trains",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Cars_Carid",
                table: "Seats",
                column: "Carid",
                principalTable: "Cars",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
