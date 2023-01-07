using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AnställdBefattningars",
                columns: new[] { "Anställdid", "Befattningid" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Anställds",
                columns: new[] { "id", "Avdelningid", "EfterNamn", "Fackförening", "FörNamn", "Lön" },
                values: new object[,]
                {
                    { 1, 1, "Parker", true, "Peter", 30000m },
                    { 2, 3, "Black", true, "Jack", 40000m },
                    { 3, 4, "Wick", true, "John", 50000m },
                    { 4, 2, "Mama", true, "Joe", 60000m }
                });

            migrationBuilder.InsertData(
                table: "Avdelnings",
                columns: new[] { "id", "Företagid", "Name" },
                values: new object[,]
                {
                    { 1, 1, "accounting" },
                    { 2, 2, "marketing" },
                    { 3, 2, "human resources" },
                    { 4, 1, "legal" }
                });

            migrationBuilder.InsertData(
                table: "Beffatnings",
                columns: new[] { "id", "Tittle" },
                values: new object[,]
                {
                    { 1, "Doctor" },
                    { 2, "Police" },
                    { 3, "Pilot" },
                    { 4, "Lumberjack" }
                });

            migrationBuilder.InsertData(
                table: "Företags",
                columns: new[] { "id", "Name", "OrgNum" },
                values: new object[,]
                {
                    { 1, "ClassOlson", 123456 },
                    { 2, "Elgiganten", 654321 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnställdBefattningars",
                keyColumns: new[] { "Anställdid", "Befattningid" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AnställdBefattningars",
                keyColumns: new[] { "Anställdid", "Befattningid" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AnställdBefattningars",
                keyColumns: new[] { "Anställdid", "Befattningid" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AnställdBefattningars",
                keyColumns: new[] { "Anställdid", "Befattningid" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Anställds",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Anställds",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Anställds",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Anställds",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Avdelnings",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Avdelnings",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Avdelnings",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Avdelnings",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Beffatnings",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Beffatnings",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Beffatnings",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Beffatnings",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Företags",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Företags",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
