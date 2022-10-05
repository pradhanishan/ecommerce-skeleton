using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.DataAccess.Migrations
{
    public partial class AddedRolesAndUserRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2584), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2588), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2592), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2592), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2593), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 5, 8, 55, 41, 441, DateTimeKind.Unspecified).AddTicks(2593), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId_UserId",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

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
        }
    }
}
