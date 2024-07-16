using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiladDarabzadeh.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 16, 8, 23, 49, 236, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 16, 8, 23, 49, 236, DateTimeKind.Local).AddTicks(6694));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 16, 1, 0, 56, 131, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 16, 1, 0, 56, 131, DateTimeKind.Local).AddTicks(2413));
        }
    }
}
