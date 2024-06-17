using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone_Shop.Migrations
{
    public partial class CreateFixAttempt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aec0e5ad-f54c-4e6c-bb7f-f14977146cb9", "AQAAAAEAACcQAAAAEFQRCAO/swEhQ6UiOwM8VfzjoYK/Wb2U+Sj+kCvuIIu6gsVTFqtTGgoCc1PbZyiQLA==", "ff1fea76-16b9-4d3c-b1dc-8394121cdc09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bff7960a-3a79-46c2-a645-631dbc506377", "AQAAAAEAACcQAAAAEOzHbP/7Y+Wh5QuNyNQA73ZktmuggzrLGQMZKitO1WPRNmCWMH4JTfGdYoahwuyhGQ==", "a689ff3c-8712-47d8-8f60-5a3644e07852" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93cbdb36-25e3-4e7b-a071-6e929ff76e07", "AQAAAAEAACcQAAAAEAKhA4N7dcL9fH1hoSfzLqbM4DKhv8zkzZ0HTqeTLHG52xSk+Hq0VmL8KLJgfnKBGg==", "d68810c3-2c97-4bd5-b98a-78963fff1c5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "988ae33f-c421-4e64-937f-4287366a1866", "AQAAAAEAACcQAAAAEA7nScrWyIG6zleBxnrLPCJWPfdcDyDnwFxL5r8wPvrZ4TTUQLNhXExiU5rQyoT2YQ==", "87487bd5-629a-49e4-8c93-b621835ef5fe" });
        }
    }
}
