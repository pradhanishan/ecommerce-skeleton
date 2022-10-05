using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.DataAccess.Migrations
{
    public partial class AddedUsersToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6679), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6679), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6681), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6681), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6682), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6682), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6683), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6685), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6685), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 32, 49, 78, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmailAddress",
                table: "Users",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7250), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7252), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7257), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7257), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
