using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiladDarabzadeh.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "LevelId",
                table: "Courses",
                type: "TINYINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "CourseDiscounts",
                columns: table => new
                {
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    DiscountTitle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisocuntPercentage = table.Column<byte>(type: "TINYINT", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDiscounts", x => x.DiscountId);
                });

            migrationBuilder.CreateTable(
                name: "CourseLevels",
                columns: table => new
                {
                    LevelId = table.Column<byte>(type: "TINYINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelTitle = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LevelColor = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLevels", x => x.LevelId);
                });

            migrationBuilder.CreateTable(
                name: "CourseModels",
                columns: table => new
                {
                    CourseModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelTitle = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseModels", x => x.CourseModelId);
                });

            migrationBuilder.CreateTable(
                name: "CycleModels",
                columns: table => new
                {
                    CycleModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelTitle = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleModels", x => x.CycleModelId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDiscounts",
                columns: table => new
                {
                    OrderDiscounId = table.Column<int>(type: "int", nullable: false),
                    DiscountCode = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: true),
                    AvaibleCount = table.Column<int>(type: "int", nullable: true),
                    Percentage = table.Column<byte>(type: "TINYINT", nullable: true),
                    PriceLimite = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDiscounts", x => x.OrderDiscounId);
                });

            migrationBuilder.CreateTable(
                name: "ModelConnections",
                columns: table => new
                {
                    CMCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelConnections", x => x.CMCId);
                    table.ForeignKey(
                        name: "FK_ModelConnections_CourseModels_ModelId",
                        column: x => x.ModelId,
                        principalTable: "CourseModels",
                        principalColumn: "CourseModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModelConnections_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseCycls",
                columns: table => new
                {
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CycleTitle = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CyclePrice = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    NumberOfSessions = table.Column<byte>(type: "TINYINT", nullable: false),
                    CycleModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCycls", x => x.CycleId);
                    table.ForeignKey(
                        name: "FK_CourseCycls_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseCycls_CycleModels_CycleModelId",
                        column: x => x.CycleModelId,
                        principalTable: "CycleModels",
                        principalColumn: "CycleModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubCycls",
                columns: table => new
                {
                    SubCycleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SesionID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseCycleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCycls", x => x.SubCycleId);
                    table.ForeignKey(
                        name: "FK_SubCycls_CourseCycls_CourseCycleId",
                        column: x => x.CourseCycleId,
                        principalTable: "CourseCycls",
                        principalColumn: "CycleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 19, 5, 3, 47, 995, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 19, 5, 3, 47, 995, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DiscountId",
                table: "Courses",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LevelId",
                table: "Courses",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCycls_CourseId",
                table: "CourseCycls",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCycls_CycleModelId",
                table: "CourseCycls",
                column: "CycleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelConnections_CourseId",
                table: "ModelConnections",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelConnections_ModelId",
                table: "ModelConnections",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCycls_CourseCycleId",
                table: "SubCycls",
                column: "CourseCycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseDiscounts_DiscountId",
                table: "Courses",
                column: "DiscountId",
                principalTable: "CourseDiscounts",
                principalColumn: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseLevels_LevelId",
                table: "Courses",
                column: "LevelId",
                principalTable: "CourseLevels",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseDiscounts_DiscountId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseLevels_LevelId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "CourseDiscounts");

            migrationBuilder.DropTable(
                name: "CourseLevels");

            migrationBuilder.DropTable(
                name: "ModelConnections");

            migrationBuilder.DropTable(
                name: "OrderDiscounts");

            migrationBuilder.DropTable(
                name: "SubCycls");

            migrationBuilder.DropTable(
                name: "CourseModels");

            migrationBuilder.DropTable(
                name: "CourseCycls");

            migrationBuilder.DropTable(
                name: "CycleModels");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DiscountId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_LevelId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "LevelId",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "TINYINT");

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
    }
}
