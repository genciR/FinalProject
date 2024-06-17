using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone_Shop.Migrations
{
    public partial class CreateFixAttempt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ca693956-3977-42bb-b70e-b229e7b83d42", "PhonestoreUser@gmail.com", "Phonestore", "User", "PHONESTOREUSER@GMAIL.COM", "PHONESTOREUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEECmVYn1aMS66sN9dgWsnL1rIVrc3llvyyuHfS3D5WjUCiZeGnlz0XiQNAYB/9EDkg==", "6f2c3ee5-cbb7-40b5-b2ef-337eca459496", "Phonestore User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "839b62a2-5638-44c3-991f-041b4fe622a5", "phonestore@admin.com", "Phonestore", "Admin", "PHONESTORE@ADMIN.COM", "PHONESTOREADMIN", "AQAAAAEAACcQAAAAEADJUeEZ0cf8LZkWEB5PcMypGrdGiObWS+YTrVjrW5hcJYCQt6cED2UqsttUVfwZfg==", "52c9e69a-b8e4-4bba-ad42-cfe09968e01e", "PhonestoreAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aec0e5ad-f54c-4e6c-bb7f-f14977146cb9", "peraUser@gmail.com", "Petar", "Petrovic", "PERAUSER@GMAIL.COM", "PERAUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEFQRCAO/swEhQ6UiOwM8VfzjoYK/Wb2U+Sj+kCvuIIu6gsVTFqtTGgoCc1PbZyiQLA==", "ff1fea76-16b9-4d3c-b1dc-8394121cdc09", "peraUser@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bff7960a-3a79-46c2-a645-631dbc506377", "markoAdmin@gmail.com", "Marko", "Obradovic", "MARKOADMIN@GMAIL.COM", "MARKOADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOzHbP/7Y+Wh5QuNyNQA73ZktmuggzrLGQMZKitO1WPRNmCWMH4JTfGdYoahwuyhGQ==", "a689ff3c-8712-47d8-8f60-5a3644e07852", "markoAdmin@gmail.com" });
        }
    }
}
