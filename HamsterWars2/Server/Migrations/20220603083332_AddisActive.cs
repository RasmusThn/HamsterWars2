using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWars2.Migrations
{
    public partial class AddisActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Hamsters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 10,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 11,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 12,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 13,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 14,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 15,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 16,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 17,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 18,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 19,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 20,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 21,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 22,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 23,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 24,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 25,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 26,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 27,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 28,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 29,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 30,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 31,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 32,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 33,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 34,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 35,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 36,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 37,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 38,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 39,
                column: "isActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 40,
                column: "isActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Hamsters");
        }
    }
}
