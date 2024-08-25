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
            migrationBuilder.RenameColumn(
                name: "IsActived",
                table: "Users",
                newName: "IsPhoneNumberActived");

            migrationBuilder.AddColumn<bool>(
                name: "IsEmailActived",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "IsEmailActived", "UserRegisterDate" },
                values: new object[] { true, new DateTime(2024, 8, 25, 6, 52, 11, 758, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "IsEmailActived", "UserRegisterDate" },
                values: new object[] { true, new DateTime(2024, 8, 25, 6, 52, 11, 758, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserEmail",
                table: "Users",
                column: "UserEmail",
                unique: true,
                filter: "[UserEmail] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserPhoneNumber",
                table: "Users",
                column: "UserPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseName",
                table: "Courses",
                column: "CourseName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseUrl",
                table: "Courses",
                column: "CourseUrl",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DemoFileName",
                table: "Courses",
                column: "DemoFileName",
                unique: true,
                filter: "[DemoFileName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_UserEmail",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserPhoneNumber",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseName",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseUrl",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DemoFileName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IsEmailActived",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "IsPhoneNumberActived",
                table: "Users",
                newName: "IsActived");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserRegisterDate",
                value: new DateTime(2024, 8, 19, 0, 20, 57, 203, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "UserRegisterDate",
                value: new DateTime(2024, 8, 19, 0, 20, 57, 203, DateTimeKind.Local).AddTicks(83));
        }
    }
}
