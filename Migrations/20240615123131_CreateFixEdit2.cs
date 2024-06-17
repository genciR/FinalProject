using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone_Shop.Migrations
{
    public partial class CreateFixEdit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bcd14fb3-ecd4-4725-ba84-e2f4ea11b72e", "peraUser@gmail.com", "Petar", "Petrovic", "PERAUSER@GMAIL.COM", "PERAUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEIwWVCwPXPTfjc7DU43dYPik3IHQsMLNKbbLJIk4T5z96mlkooRCsVA4pCfvNR7bsQ==", "ecf11a8e-d0ee-4f51-ab04-43104f925c2e", "peraUser@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "94761e97-75b0-4b4e-8d26-2a824ae0a48c", "markoAdmin@gmail.com", "Marko", "Obradovic", "MARKOADMIN@GMAIL.COM", "MARKOADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKtotMbij9C+AlLzvr7czEzgkchwEEIgFSYl4bHjyDI4c3S3tpAgPhjspTs9BItFWg==", "d08f682f-47d5-47e4-8e06-c71dc81756fb", "markoAdmin@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2b21331b-886b-4fa6-bce9-5fd8812bb5df", "PhonestoreUser@gmail.com", "Phonestore", "User", "PHONESTOREUSER@GMAIL.COM", "PHONESTOREUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEL8Gv3CRJY5v1Fy3epgUkO0jxm65bMUyHWEq0jf6aEKY2pYaL+BAM7qXqRitIbSSMQ==", "e08697ae-e69e-4599-8d60-45b68a005c49", "Phonestore User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fb4ffce3-6562-4440-94b0-19b36c2fa632", "phonestore@admin.com", "Phonestore", "Admin", "PHONESTORE@ADMIN.COM", "PHONESTOREADMIN", "AQAAAAEAACcQAAAAEK+e6KyxF7pzPSkD1RIK4gChb5MKrypqum+/T/PJ00hQq8uy9KorLjvWf6NLVlaSoA==", "c2419ceb-b0b0-4d84-9a0f-aca5c8987197", "PhonestoreAdmin" });
        }
    }
}
