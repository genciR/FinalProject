using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone_Shop.Migrations
{
    public partial class CreateFixEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b21331b-886b-4fa6-bce9-5fd8812bb5df", "AQAAAAEAACcQAAAAEL8Gv3CRJY5v1Fy3epgUkO0jxm65bMUyHWEq0jf6aEKY2pYaL+BAM7qXqRitIbSSMQ==", "e08697ae-e69e-4599-8d60-45b68a005c49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb4ffce3-6562-4440-94b0-19b36c2fa632", "AQAAAAEAACcQAAAAEK+e6KyxF7pzPSkD1RIK4gChb5MKrypqum+/T/PJ00hQq8uy9KorLjvWf6NLVlaSoA==", "c2419ceb-b0b0-4d84-9a0f-aca5c8987197" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca693956-3977-42bb-b70e-b229e7b83d42", "AQAAAAEAACcQAAAAEECmVYn1aMS66sN9dgWsnL1rIVrc3llvyyuHfS3D5WjUCiZeGnlz0XiQNAYB/9EDkg==", "6f2c3ee5-cbb7-40b5-b2ef-337eca459496" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "839b62a2-5638-44c3-991f-041b4fe622a5", "AQAAAAEAACcQAAAAEADJUeEZ0cf8LZkWEB5PcMypGrdGiObWS+YTrVjrW5hcJYCQt6cED2UqsttUVfwZfg==", "52c9e69a-b8e4-4bba-ad42-cfe09968e01e" });
        }
    }
}
