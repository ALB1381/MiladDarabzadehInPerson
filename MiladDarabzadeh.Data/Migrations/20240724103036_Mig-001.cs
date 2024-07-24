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
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseDiscounts_DiscountId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DiscountId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "CourseCycls",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sum = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFinally = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_OrderDiscounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "OrderDiscounts",
                        principalColumn: "OrderDiscounId");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubOrders",
                columns: table => new
                {
                    SubOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CyclePrice = table.Column<int>(type: "int", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOrders", x => x.SubOrderId);
                    table.ForeignKey(
                        name: "FK_SubOrders_CourseCycls_CycleId",
                        column: x => x.CycleId,
                        principalTable: "CourseCycls",
                        principalColumn: "CycleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubOrders_CourseDiscounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "CourseDiscounts",
                        principalColumn: "DiscountId");
                    table.ForeignKey(
                        name: "FK_SubOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 24, 3, 30, 36, 261, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 24, 3, 30, 36, 261, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.CreateIndex(
                name: "IX_CourseCycls_DiscountId",
                table: "CourseCycls",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DiscountId",
                table: "Orders",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOrders_CycleId",
                table: "SubOrders",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOrders_DiscountId",
                table: "SubOrders",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOrders_OrderId",
                table: "SubOrders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseCycls_CourseDiscounts_DiscountId",
                table: "CourseCycls",
                column: "DiscountId",
                principalTable: "CourseDiscounts",
                principalColumn: "DiscountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseCycls_CourseDiscounts_DiscountId",
                table: "CourseCycls");

            migrationBuilder.DropTable(
                name: "SubOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_CourseCycls_DiscountId",
                table: "CourseCycls");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "CourseCycls");

            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 24, 2, 37, 29, 711, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 24, 2, 37, 29, 711, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DiscountId",
                table: "Courses",
                column: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseDiscounts_DiscountId",
                table: "Courses",
                column: "DiscountId",
                principalTable: "CourseDiscounts",
                principalColumn: "DiscountId");
        }
    }
}
