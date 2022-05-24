using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWars2.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 1, "Pizza", 0, "/images/hamsters/hamster-9.jpg", 0, "Hjulet", "Rasmus", 0 },
                    { 2, 2, "Fika", 0, "/images/hamsters/hamster-8.jpg", 0, "Meetings", "Jimmy", 0 },
                    { 3, 3, "Pancakes", 0, "/images/hamsters/hamster-7.jpg", 0, "Intellisense", "Claes", 0 },
                    { 4, 2, "Korv", 0, "/images/hamsters/hamster-1.jpg", 0, "Korvar", "Korven", 0 },
                    { 5, 2, "Sallad", 0, "/images/hamsters/hamster-2.jpg", 0, "Jumping", "Patrik", 0 },
                    { 6, 4, "Bark", 0, "/images/hamsters/hamster-3.jpg", 0, "Kvivksilver", "Pontus", 0 },
                    { 7, 7, "Popcorn", 0, "/images/hamsters/hamster-4.jpg", 0, "Berras Bio", "Mikael", 0 },
                    { 8, 10, "Bark", 0, "/images/hamsters/hamster-5.jpg", 0, "Träd", "Bävern", 0 },
                    { 9, 2, "Blötmat", 0, "/images/hamsters/hamster-6.jpg", 0, "Lekar", "Kattis", 0 },
                    { 10, 3, "FUZEON", 0, "/images/hamsters/hamster-10.jpg", 0, "Kids", "Hyaena", 0 },
                    { 11, 3, "Sallad", 0, "/images/hamsters/hamster-11.jpg", 0, "Lekar", "Kingfisher", 0 },
                    { 12, 4, "Bark", 0, "/images/hamsters/hamster-12.jpg", 0, "Hjulet", "Robin", 0 },
                    { 13, 1, "Sallad", 0, "/images/hamsters/hamster-13.jpg", 0, "Lekar", "Lynx", 0 },
                    { 14, 1, "Bark", 0, "/images/hamsters/hamster-14.jpg", 0, "Lekar", "Duck", 0 },
                    { 15, 2, "Blötmat", 0, "/images/hamsters/hamster-15.jpg", 0, "Hjulet", "Rhinoceros", 0 },
                    { 16, 3, "Sallad", 0, "/images/hamsters/hamster-16.jpg", 0, "Lekar", "Red", 0 },
                    { 17, 1, "Bark", 0, "/images/hamsters/hamster-17.jpg", 0, "Hjulet", "Gazelle", 0 },
                    { 18, 5, "Sallad", 0, "/images/hamsters/hamster-18.jpg", 0, "Lekar", "Dragon", 0 },
                    { 19, 4, "Blötmat", 0, "/images/hamsters/hamster-19.jpg", 0, "Lekar", "Lourie", 0 },
                    { 20, 3, "Bark", 0, "/images/hamsters/hamster-20.jpg", 0, "Hjulet", "Squirrel", 0 },
                    { 21, 2, "Sallad", 0, "/images/hamsters/hamster-21.jpg", 0, "Lekar", "Carmine", 0 },
                    { 22, 2, "Popcorn", 0, "/images/hamsters/hamster-22.jpg", 0, "Hjulet", "Snake", 0 },
                    { 23, 1, "Sallad", 0, "/images/hamsters/hamster-23.jpg", 0, "Lekar", "Bear", 0 },
                    { 24, 3, "Bark", 0, "/images/hamsters/hamster-24.jpg", 0, "Hjulet", "Chickadee", 0 },
                    { 25, 3, "Sallad", 0, "/images/hamsters/hamster-25.jpg", 0, "Lekar", "Vervet ", 0 },
                    { 26, 3, "Bark", 0, "/images/hamsters/hamster-26.jpg", 0, "Hjulet", "Malagasy ", 0 },
                    { 27, 3, "Sallad", 0, "/images/hamsters/hamster-27.jpg", 0, "Lekar", "Malleefowl", 0 },
                    { 28, 1, "Bark", 0, "/images/hamsters/hamster-28.jpg", 0, "Hjulet", "Desert", 0 },
                    { 29, 2, "Popcorn", 0, "/images/hamsters/hamster-29.jpg", 0, "Lekar", "Kaffir", 0 },
                    { 30, 1, "Sallad", 0, "/images/hamsters/hamster-30.jpg", 0, "Lekar", "Nubian ", 0 },
                    { 31, 2, "Popcorn", 0, "/images/hamsters/hamster-31.jpg", 0, "Hjulet", "Macaw", 0 },
                    { 32, 3, "Blötmat", 0, "/images/hamsters/hamster-32.jpg", 0, "Lekar", "Woodcock", 0 },
                    { 33, 4, "Sallad", 0, "/images/hamsters/hamster-33.jpg", 0, "Hjulet", "Eurasian", 0 },
                    { 34, 4, "Gräs", 0, "/images/hamsters/hamster-34.jpg", 0, "Lekar", "Mynah", 0 },
                    { 35, 4, "Popcorn", 0, "/images/hamsters/hamster-35.jpg", 0, "Lekar", "Sportive", 0 },
                    { 36, 3, "Gräs", 0, "/images/hamsters/hamster-36.jpg", 0, "Hjulet", "Marten", 0 },
                    { 37, 2, "Sallad", 0, "/images/hamsters/hamster-37.jpg", 0, "Lekar", "Malagasy", 0 },
                    { 38, 1, "Popcorn", 0, "/images/hamsters/hamster-38.jpg", 0, "Hjulet", "Grey ", 0 },
                    { 39, 1, "Gräs", 0, "/images/hamsters/hamster-39.jpg", 0, "Lekar", "Bear", 0 },
                    { 40, 2, "Sallad", 0, "/images/hamsters/hamster-40.jpg", 0, "Hjulet", "Four", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
