using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiladDarabzadeh.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "CourseGroups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseGroups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_CourseGroups_CourseGroups_ParentId",
                        column: x => x.ParentId,
                        principalTable: "CourseGroups",
                        principalColumn: "GroupId");
                });

            migrationBuilder.CreateTable(
                name: "CourseLevels",
                columns: table => new
                {
                    LevelId = table.Column<byte>(type: "TINYINT", nullable: false),
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
                    CourseModelId = table.Column<byte>(type: "TINYINT", nullable: false),
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
                    CycleModelId = table.Column<byte>(type: "TINYINT", nullable: false),
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
                name: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<byte>(type: "TINYINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionTitle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleTitle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissionConnections",
                columns: table => new
                {
                    RPCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissionConnections", x => x.RPCId);
                    table.ForeignKey(
                        name: "FK_RolePermissionConnections_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermissionConnections_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    UserNandF = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    UserPhoneNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    UserRegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAvatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserActiveCodeForEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserActiveCodeForPhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsActived = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseTags = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CourseUrl = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FirstTimeMadeDate = table.Column<DateOnly>(type: "date", nullable: false),
                    NamesOfTheBooks = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    MinAge = table.Column<byte>(type: "TINYINT", nullable: true),
                    MaxAge = table.Column<byte>(type: "TINYINT", nullable: true),
                    RangeOfIELTSInThisCourse = table.Column<byte>(type: "TINYINT", nullable: true),
                    RangeOfListeningInThisCourse = table.Column<byte>(type: "TINYINT", nullable: true),
                    RangeOfWritingInThisCourse = table.Column<byte>(type: "TINYINT", nullable: true),
                    RangeOfReadingInThisCourse = table.Column<byte>(type: "TINYINT", nullable: true),
                    RangeOfSpeakingInThisCourse = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LoanPayments = table.Column<bool>(type: "bit", nullable: false),
                    Certificate = table.Column<bool>(type: "bit", nullable: false),
                    CourseImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DemoFileName = table.Column<string>(type: "nvarchar(250)", maxLength: 100, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    SubGroupId = table.Column<int>(type: "int", nullable: true),
                    DiscountId = table.Column<int>(type: "int", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<byte>(type: "TINYINT", nullable: false),
                    SupplementId = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_CourseDiscounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "CourseDiscounts",
                        principalColumn: "DiscountId");
                    table.ForeignKey(
                        name: "FK_Courses_CourseGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "CourseGroups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_CourseGroups_SubGroupId",
                        column: x => x.SubGroupId,
                        principalTable: "CourseGroups",
                        principalColumn: "GroupId");
                    table.ForeignKey(
                        name: "FK_Courses_CourseLevels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "CourseLevels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_Users_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Users",
                        principalColumn: "UserId",
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
                    CycleModelId = table.Column<byte>(type: "TINYINT", nullable: false)
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
                name: "ModelConnections",
                columns: table => new
                {
                    CMCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<byte>(type: "TINYINT", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleTitle" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Student" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "BirthDate", "IsActived", "RoleId", "UserActiveCodeForEmail", "UserActiveCodeForPhoneNumber", "UserAvatar", "UserEmail", "UserName", "UserNandF", "UserPassword", "UserPhoneNumber", "UserRegisterDate" },
                values: new object[,]
                {
                    { 1, null, true, 1, "0569d3e33ac94bcc8c5ee4f93320db45", "0569d3e33ac94bcc8c5ee4f93320db45", "Defult.jpg", "Milad.tutor@gmail.com", "MiladDarabzadeh", "Milad Darabzadeh", "62-D5-ED-C9-B0-AD-74-B5-AE-96-2E-5F-7F-C7-91-51", "09139279581", new DateTime(2024, 7, 24, 2, 37, 29, 711, DateTimeKind.Local).AddTicks(4167) },
                    { 2, null, true, 1, "c53eac7994034d13a36e475e1e00fcac", "c53eac7994034d13a36e475e1e00fcac", "cc4129b2b7db4c1ea499fa5a6208df5d.jpg", "alibarzegar013@gmail.com", "AliBarzegar", "Ali Barzegar", "0C-0B-33-26-C9-5A-66-D7-37-7A-0A-2F-75-DA-AC-34", "09397894663", new DateTime(2024, 7, 24, 2, 37, 29, 711, DateTimeKind.Local).AddTicks(4173) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseCycls_CourseId",
                table: "CourseCycls",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCycls_CycleModelId",
                table: "CourseCycls",
                column: "CycleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroups_ParentId",
                table: "CourseGroups",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DiscountId",
                table: "Courses",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_GroupId",
                table: "Courses",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LevelId",
                table: "Courses",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SubGroupId",
                table: "Courses",
                column: "SubGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelConnections_CourseId",
                table: "ModelConnections",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelConnections_ModelId",
                table: "ModelConnections",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionConnections_PermissionId",
                table: "RolePermissionConnections",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionConnections_RoleId",
                table: "RolePermissionConnections",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCycls_CourseCycleId",
                table: "SubCycls",
                column: "CourseCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelConnections");

            migrationBuilder.DropTable(
                name: "OrderDiscounts");

            migrationBuilder.DropTable(
                name: "RolePermissionConnections");

            migrationBuilder.DropTable(
                name: "SubCycls");

            migrationBuilder.DropTable(
                name: "CourseModels");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "CourseCycls");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CycleModels");

            migrationBuilder.DropTable(
                name: "CourseDiscounts");

            migrationBuilder.DropTable(
                name: "CourseGroups");

            migrationBuilder.DropTable(
                name: "CourseLevels");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
