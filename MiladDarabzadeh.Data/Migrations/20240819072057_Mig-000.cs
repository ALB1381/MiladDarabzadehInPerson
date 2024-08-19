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
                name: "Exams",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CountOfQuestions = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<short>(type: "smallint", nullable: true),
                    QuestionCount = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamId);
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
                name: "QuestionGroups",
                columns: table => new
                {
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false),
                    QuestionGroupTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionGroups", x => x.QuestionGroupId);
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
                name: "AudioQuestionAnsweredByAudios",
                columns: table => new
                {
                    AudioQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    AudioFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    PlayingLimit = table.Column<byte>(type: "TINYINT", nullable: true),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioQuestionAnsweredByAudios", x => x.AudioQuestionId);
                    table.ForeignKey(
                        name: "FK_AudioQuestionAnsweredByAudios_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AudioQuestionAnsweredBySelectings",
                columns: table => new
                {
                    AudioQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    AudioFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    PlayingLimit = table.Column<byte>(type: "TINYINT", nullable: true),
                    doesItMultipleSelective = table.Column<bool>(type: "bit", nullable: false),
                    optionOneValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionOneText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionTwoValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionTwoText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionThreeValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionThreeText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFourValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFourText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFiveValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFiveText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionSixValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionSixText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioQuestionAnsweredBySelectings", x => x.AudioQuestionId);
                    table.ForeignKey(
                        name: "FK_AudioQuestionAnsweredBySelectings_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AudioQuestionAnsweredByTexts",
                columns: table => new
                {
                    AudioQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    AudioFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    PlayingLimit = table.Column<byte>(type: "TINYINT", nullable: true),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioQuestionAnsweredByTexts", x => x.AudioQuestionId);
                    table.ForeignKey(
                        name: "FK_AudioQuestionAnsweredByTexts_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PictureQuestionAnsweredByAudios",
                columns: table => new
                {
                    pictureQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    imageFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureQuestionAnsweredByAudios", x => x.pictureQuestionId);
                    table.ForeignKey(
                        name: "FK_PictureQuestionAnsweredByAudios_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PictureQuestionAnsweredBySelectings",
                columns: table => new
                {
                    pictureQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    imageFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    doesItMultipleSelective = table.Column<bool>(type: "bit", nullable: false),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    optionOneValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionOneText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionTwoValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionTwoText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionThreeValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionThreeText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFourValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFourText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFiveValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFiveText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionSixValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionSixText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureQuestionAnsweredBySelectings", x => x.pictureQuestionId);
                    table.ForeignKey(
                        name: "FK_PictureQuestionAnsweredBySelectings_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PictureQuestionAnsweredByTexts",
                columns: table => new
                {
                    pictureQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    imageFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureQuestionAnsweredByTexts", x => x.pictureQuestionId);
                    table.ForeignKey(
                        name: "FK_PictureQuestionAnsweredByTexts_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextualQuestionAnsweredByAudios",
                columns: table => new
                {
                    textualQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextualQuestionAnsweredByAudios", x => x.textualQuestionId);
                    table.ForeignKey(
                        name: "FK_TextualQuestionAnsweredByAudios_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextualQuestionAnsweredBySelectings",
                columns: table => new
                {
                    textualQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    doesItMultipleSelective = table.Column<bool>(type: "bit", nullable: false),
                    optionOneValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionOneText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionTwoValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionTwoText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionThreeValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionThreeText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFourValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFourText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFiveValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFiveText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionSixValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionSixText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextualQuestionAnsweredBySelectings", x => x.textualQuestionId);
                    table.ForeignKey(
                        name: "FK_TextualQuestionAnsweredBySelectings_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextualQuestionAnsweredByTexts",
                columns: table => new
                {
                    textualQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextualQuestionAnsweredByTexts", x => x.textualQuestionId);
                    table.ForeignKey(
                        name: "FK_TextualQuestionAnsweredByTexts_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoQuestionAnsweredByAudios",
                columns: table => new
                {
                    videoQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    VideoFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    PlayingLimit = table.Column<byte>(type: "TINYINT", nullable: true),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoQuestionAnsweredByAudios", x => x.videoQuestionId);
                    table.ForeignKey(
                        name: "FK_VideoQuestionAnsweredByAudios_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoQuestionAnsweredBySelectings",
                columns: table => new
                {
                    videoQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    VideoFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    PlayingLimit = table.Column<byte>(type: "TINYINT", nullable: true),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    doesItMultipleSelective = table.Column<bool>(type: "bit", nullable: false),
                    optionOneValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionOneText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionTwoValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionTwoText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionThreeValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionThreeText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFourValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFourText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFiveValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFiveText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionSixValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionSixText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoQuestionAnsweredBySelectings", x => x.videoQuestionId);
                    table.ForeignKey(
                        name: "FK_VideoQuestionAnsweredBySelectings_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoQuestionAnsweredByTexts",
                columns: table => new
                {
                    videoQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    VideoFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    PlayingLimit = table.Column<byte>(type: "TINYINT", nullable: true),
                    FixedScore = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    QuestionGroupId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoQuestionAnsweredByTexts", x => x.videoQuestionId);
                    table.ForeignKey(
                        name: "FK_VideoQuestionAnsweredByTexts_QuestionGroups_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroups",
                        principalColumn: "QuestionGroupId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "QuestionExamConnections",
                columns: table => new
                {
                    QuestionExamConnectionId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    AudioQuestionAnsweredByAudioId = table.Column<int>(type: "int", nullable: true),
                    audioQuestionAnsweredBySelectingId = table.Column<int>(type: "int", nullable: true),
                    audioQuestionAnsweredByTextId = table.Column<int>(type: "int", nullable: true),
                    PictureQuestionAnsweredByAudioId = table.Column<int>(type: "int", nullable: true),
                    pictureQuestionAnsweredBySelectingId = table.Column<int>(type: "int", nullable: true),
                    pictureQuestionAnsweredByTextId = table.Column<int>(type: "int", nullable: true),
                    TextualQuestionAnsweredByAudioId = table.Column<int>(type: "int", nullable: true),
                    textualQuestionAnsweredBySelectingId = table.Column<int>(type: "int", nullable: true),
                    textualQuestionAnsweredByTextId = table.Column<int>(type: "int", nullable: true),
                    VideoQuestionAnsweredByAudioId = table.Column<int>(type: "int", nullable: true),
                    videoQuestionAnsweredBySelectingId = table.Column<int>(type: "int", nullable: true),
                    videoQuestionAnsweredByTextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionExamConnections", x => x.QuestionExamConnectionId);
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_AudioQuestionAnsweredByAudios_AudioQuestionAnsweredByAudioId",
                        column: x => x.AudioQuestionAnsweredByAudioId,
                        principalTable: "AudioQuestionAnsweredByAudios",
                        principalColumn: "AudioQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_AudioQuestionAnsweredBySelectings_audioQuestionAnsweredBySelectingId",
                        column: x => x.audioQuestionAnsweredBySelectingId,
                        principalTable: "AudioQuestionAnsweredBySelectings",
                        principalColumn: "AudioQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_AudioQuestionAnsweredByTexts_audioQuestionAnsweredByTextId",
                        column: x => x.audioQuestionAnsweredByTextId,
                        principalTable: "AudioQuestionAnsweredByTexts",
                        principalColumn: "AudioQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_PictureQuestionAnsweredByAudios_PictureQuestionAnsweredByAudioId",
                        column: x => x.PictureQuestionAnsweredByAudioId,
                        principalTable: "PictureQuestionAnsweredByAudios",
                        principalColumn: "pictureQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_PictureQuestionAnsweredBySelectings_pictureQuestionAnsweredBySelectingId",
                        column: x => x.pictureQuestionAnsweredBySelectingId,
                        principalTable: "PictureQuestionAnsweredBySelectings",
                        principalColumn: "pictureQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_PictureQuestionAnsweredByTexts_pictureQuestionAnsweredByTextId",
                        column: x => x.pictureQuestionAnsweredByTextId,
                        principalTable: "PictureQuestionAnsweredByTexts",
                        principalColumn: "pictureQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_TextualQuestionAnsweredByAudios_TextualQuestionAnsweredByAudioId",
                        column: x => x.TextualQuestionAnsweredByAudioId,
                        principalTable: "TextualQuestionAnsweredByAudios",
                        principalColumn: "textualQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_TextualQuestionAnsweredBySelectings_textualQuestionAnsweredBySelectingId",
                        column: x => x.textualQuestionAnsweredBySelectingId,
                        principalTable: "TextualQuestionAnsweredBySelectings",
                        principalColumn: "textualQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_TextualQuestionAnsweredByTexts_textualQuestionAnsweredByTextId",
                        column: x => x.textualQuestionAnsweredByTextId,
                        principalTable: "TextualQuestionAnsweredByTexts",
                        principalColumn: "textualQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_VideoQuestionAnsweredByAudios_VideoQuestionAnsweredByAudioId",
                        column: x => x.VideoQuestionAnsweredByAudioId,
                        principalTable: "VideoQuestionAnsweredByAudios",
                        principalColumn: "videoQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_VideoQuestionAnsweredBySelectings_videoQuestionAnsweredBySelectingId",
                        column: x => x.videoQuestionAnsweredBySelectingId,
                        principalTable: "VideoQuestionAnsweredBySelectings",
                        principalColumn: "videoQuestionId");
                    table.ForeignKey(
                        name: "FK_QuestionExamConnections_VideoQuestionAnsweredByTexts_videoQuestionAnsweredByTextId",
                        column: x => x.videoQuestionAnsweredByTextId,
                        principalTable: "VideoQuestionAnsweredByTexts",
                        principalColumn: "videoQuestionId");
                });

            migrationBuilder.CreateTable(
                name: "AudioAnswerQuestionedByAudios",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    audioQuestionAnsweredByAudioId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioAnswerQuestionedByAudios", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_AudioAnswerQuestionedByAudios_AudioQuestionAnsweredByAudios_audioQuestionAnsweredByAudioId",
                        column: x => x.audioQuestionAnsweredByAudioId,
                        principalTable: "AudioQuestionAnsweredByAudios",
                        principalColumn: "AudioQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AudioAnswerQuestionedByAudios_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AudioAnswerQuestionedByPictures",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    PictureQuestionAnsweredByAudioId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioAnswerQuestionedByPictures", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_AudioAnswerQuestionedByPictures_PictureQuestionAnsweredByAudios_PictureQuestionAnsweredByAudioId",
                        column: x => x.PictureQuestionAnsweredByAudioId,
                        principalTable: "PictureQuestionAnsweredByAudios",
                        principalColumn: "pictureQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AudioAnswerQuestionedByPictures_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AudioAnswerQuestionedByTexts",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    textualQuestionAnsweredByAudioId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioAnswerQuestionedByTexts", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_AudioAnswerQuestionedByTexts_TextualQuestionAnsweredByAudios_textualQuestionAnsweredByAudioId",
                        column: x => x.textualQuestionAnsweredByAudioId,
                        principalTable: "TextualQuestionAnsweredByAudios",
                        principalColumn: "textualQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AudioAnswerQuestionedByTexts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AudioAnswerQuestionedByVideos",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    videoQuestionAnsweredByAudioId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioAnswerQuestionedByVideos", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_AudioAnswerQuestionedByVideos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AudioAnswerQuestionedByVideos_VideoQuestionAnsweredByAudios_videoQuestionAnsweredByAudioId",
                        column: x => x.videoQuestionAnsweredByAudioId,
                        principalTable: "VideoQuestionAnsweredByAudios",
                        principalColumn: "videoQuestionId",
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
                name: "selectingAnswerQuestionedByAudios",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    audioQuestionAnsweredBySelectingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_selectingAnswerQuestionedByAudios", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_selectingAnswerQuestionedByAudios_AudioQuestionAnsweredBySelectings_audioQuestionAnsweredBySelectingId",
                        column: x => x.audioQuestionAnsweredBySelectingId,
                        principalTable: "AudioQuestionAnsweredBySelectings",
                        principalColumn: "AudioQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_selectingAnswerQuestionedByAudios_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SelectingAnswerQuestionedByPictures",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    pictureQuestionAnsweredBySelectingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectingAnswerQuestionedByPictures", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_SelectingAnswerQuestionedByPictures_PictureQuestionAnsweredBySelectings_pictureQuestionAnsweredBySelectingId",
                        column: x => x.pictureQuestionAnsweredBySelectingId,
                        principalTable: "PictureQuestionAnsweredBySelectings",
                        principalColumn: "pictureQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SelectingAnswerQuestionedByPictures_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SelectingAnswerQuestionedByTexts",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    textualQuestionAnsweredBySelectingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectingAnswerQuestionedByTexts", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_SelectingAnswerQuestionedByTexts_TextualQuestionAnsweredBySelectings_textualQuestionAnsweredBySelectingId",
                        column: x => x.textualQuestionAnsweredBySelectingId,
                        principalTable: "TextualQuestionAnsweredBySelectings",
                        principalColumn: "textualQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SelectingAnswerQuestionedByTexts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SelectingAnswerQuestionedByVideos",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    videoQuestionAnsweredBySelectingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectingAnswerQuestionedByVideos", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_SelectingAnswerQuestionedByVideos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SelectingAnswerQuestionedByVideos_VideoQuestionAnsweredBySelectings_videoQuestionAnsweredBySelectingId",
                        column: x => x.videoQuestionAnsweredBySelectingId,
                        principalTable: "VideoQuestionAnsweredBySelectings",
                        principalColumn: "videoQuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextAnswerQuestionedByAudios",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    audioQuestionAnsweredBytextId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextAnswerQuestionedByAudios", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_TextAnswerQuestionedByAudios_AudioQuestionAnsweredByTexts_audioQuestionAnsweredBytextId",
                        column: x => x.audioQuestionAnsweredBytextId,
                        principalTable: "AudioQuestionAnsweredByTexts",
                        principalColumn: "AudioQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TextAnswerQuestionedByAudios_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextAnswerQuestionedByPictures",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    pictureQuestionAnsweredByTextId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextAnswerQuestionedByPictures", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_TextAnswerQuestionedByPictures_PictureQuestionAnsweredByTexts_pictureQuestionAnsweredByTextId",
                        column: x => x.pictureQuestionAnsweredByTextId,
                        principalTable: "PictureQuestionAnsweredByTexts",
                        principalColumn: "pictureQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TextAnswerQuestionedByPictures_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextAnswerQuestionedByTexts",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    textualQuestionAnsweredByTextId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextAnswerQuestionedByTexts", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_TextAnswerQuestionedByTexts_TextualQuestionAnsweredByTexts_textualQuestionAnsweredByTextId",
                        column: x => x.textualQuestionAnsweredByTextId,
                        principalTable: "TextualQuestionAnsweredByTexts",
                        principalColumn: "textualQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TextAnswerQuestionedByTexts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextAnswerQuestionedByVIdeos",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    videoQuestionAnsweredByTextId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextAnswerQuestionedByVIdeos", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_TextAnswerQuestionedByVIdeos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TextAnswerQuestionedByVIdeos_VideoQuestionAnsweredByTexts_videoQuestionAnsweredByTextId",
                        column: x => x.videoQuestionAnsweredByTextId,
                        principalTable: "VideoQuestionAnsweredByTexts",
                        principalColumn: "videoQuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserScoreExams",
                columns: table => new
                {
                    USEId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScoreExams", x => x.USEId);
                    table.ForeignKey(
                        name: "FK_UserScoreExams_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserScoreExams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseCycles",
                columns: table => new
                {
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CycleTitle = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CyclePrice = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: true),
                    NumberOfSessions = table.Column<byte>(type: "TINYINT", nullable: false),
                    CycleModelId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCycles", x => x.CycleId);
                    table.ForeignKey(
                        name: "FK_CourseCycles_CourseDiscounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "CourseDiscounts",
                        principalColumn: "DiscountId");
                    table.ForeignKey(
                        name: "FK_CourseCycles_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseCycles_CycleModels_CycleModelId",
                        column: x => x.CycleModelId,
                        principalTable: "CycleModels",
                        principalColumn: "CycleModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseModelConnections",
                columns: table => new
                {
                    CMCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseModelConnections", x => x.CMCId);
                    table.ForeignKey(
                        name: "FK_CourseModelConnections_CourseModels_ModelId",
                        column: x => x.ModelId,
                        principalTable: "CourseModels",
                        principalColumn: "CourseModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseModelConnections_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamCycleConnections",
                columns: table => new
                {
                    ECCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamCycleConnections", x => x.ECCId);
                    table.ForeignKey(
                        name: "FK_ExamCycleConnections_CourseCycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "CourseCycles",
                        principalColumn: "CycleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamCycleConnections_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubCycles",
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
                    table.PrimaryKey("PK_SubCycles", x => x.SubCycleId);
                    table.ForeignKey(
                        name: "FK_SubCycles_CourseCycles_CourseCycleId",
                        column: x => x.CourseCycleId,
                        principalTable: "CourseCycles",
                        principalColumn: "CycleId",
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
                        name: "FK_SubOrders_CourseCycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "CourseCycles",
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
                    { 1, null, true, 1, "0569d3e33ac94bcc8c5ee4f93320db45", "0569d3e33ac94bcc8c5ee4f93320db45", "Defult.jpg", "Milad.tutor@gmail.com", "MiladDarabzadeh", "Milad Darabzadeh", "62-D5-ED-C9-B0-AD-74-B5-AE-96-2E-5F-7F-C7-91-51", "09139279581", new DateTime(2024, 8, 19, 0, 20, 57, 203, DateTimeKind.Local).AddTicks(74) },
                    { 2, null, true, 1, "c53eac7994034d13a36e475e1e00fcac", "c53eac7994034d13a36e475e1e00fcac", "cc4129b2b7db4c1ea499fa5a6208df5d.jpg", "alibarzegar013@gmail.com", "AliBarzegar", "Ali Barzegar", "0C-0B-33-26-C9-5A-66-D7-37-7A-0A-2F-75-DA-AC-34", "09397894663", new DateTime(2024, 8, 19, 0, 20, 57, 203, DateTimeKind.Local).AddTicks(83) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AudioAnswerQuestionedByAudios_audioQuestionAnsweredByAudioId",
                table: "AudioAnswerQuestionedByAudios",
                column: "audioQuestionAnsweredByAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioAnswerQuestionedByAudios_UserId",
                table: "AudioAnswerQuestionedByAudios",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioAnswerQuestionedByPictures_PictureQuestionAnsweredByAudioId",
                table: "AudioAnswerQuestionedByPictures",
                column: "PictureQuestionAnsweredByAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioAnswerQuestionedByPictures_UserId",
                table: "AudioAnswerQuestionedByPictures",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioAnswerQuestionedByTexts_textualQuestionAnsweredByAudioId",
                table: "AudioAnswerQuestionedByTexts",
                column: "textualQuestionAnsweredByAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioAnswerQuestionedByTexts_UserId",
                table: "AudioAnswerQuestionedByTexts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioAnswerQuestionedByVideos_UserId",
                table: "AudioAnswerQuestionedByVideos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioAnswerQuestionedByVideos_videoQuestionAnsweredByAudioId",
                table: "AudioAnswerQuestionedByVideos",
                column: "videoQuestionAnsweredByAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioQuestionAnsweredByAudios_QuestionGroupId",
                table: "AudioQuestionAnsweredByAudios",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioQuestionAnsweredBySelectings_QuestionGroupId",
                table: "AudioQuestionAnsweredBySelectings",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioQuestionAnsweredByTexts_QuestionGroupId",
                table: "AudioQuestionAnsweredByTexts",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCycles_CourseId",
                table: "CourseCycles",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCycles_CycleModelId",
                table: "CourseCycles",
                column: "CycleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCycles_DiscountId",
                table: "CourseCycles",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroups_ParentId",
                table: "CourseGroups",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseModelConnections_CourseId",
                table: "CourseModelConnections",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseModelConnections_ModelId",
                table: "CourseModelConnections",
                column: "ModelId");

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
                name: "IX_ExamCycleConnections_CycleId",
                table: "ExamCycleConnections",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamCycleConnections_ExamId",
                table: "ExamCycleConnections",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DiscountId",
                table: "Orders",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PictureQuestionAnsweredByAudios_QuestionGroupId",
                table: "PictureQuestionAnsweredByAudios",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PictureQuestionAnsweredBySelectings_QuestionGroupId",
                table: "PictureQuestionAnsweredBySelectings",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PictureQuestionAnsweredByTexts_QuestionGroupId",
                table: "PictureQuestionAnsweredByTexts",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_AudioQuestionAnsweredByAudioId",
                table: "QuestionExamConnections",
                column: "AudioQuestionAnsweredByAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_audioQuestionAnsweredBySelectingId",
                table: "QuestionExamConnections",
                column: "audioQuestionAnsweredBySelectingId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_audioQuestionAnsweredByTextId",
                table: "QuestionExamConnections",
                column: "audioQuestionAnsweredByTextId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_ExamId",
                table: "QuestionExamConnections",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_PictureQuestionAnsweredByAudioId",
                table: "QuestionExamConnections",
                column: "PictureQuestionAnsweredByAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_pictureQuestionAnsweredBySelectingId",
                table: "QuestionExamConnections",
                column: "pictureQuestionAnsweredBySelectingId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_pictureQuestionAnsweredByTextId",
                table: "QuestionExamConnections",
                column: "pictureQuestionAnsweredByTextId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_TextualQuestionAnsweredByAudioId",
                table: "QuestionExamConnections",
                column: "TextualQuestionAnsweredByAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_textualQuestionAnsweredBySelectingId",
                table: "QuestionExamConnections",
                column: "textualQuestionAnsweredBySelectingId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_textualQuestionAnsweredByTextId",
                table: "QuestionExamConnections",
                column: "textualQuestionAnsweredByTextId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_VideoQuestionAnsweredByAudioId",
                table: "QuestionExamConnections",
                column: "VideoQuestionAnsweredByAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_videoQuestionAnsweredBySelectingId",
                table: "QuestionExamConnections",
                column: "videoQuestionAnsweredBySelectingId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExamConnections_videoQuestionAnsweredByTextId",
                table: "QuestionExamConnections",
                column: "videoQuestionAnsweredByTextId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionConnections_PermissionId",
                table: "RolePermissionConnections",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionConnections_RoleId",
                table: "RolePermissionConnections",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_selectingAnswerQuestionedByAudios_audioQuestionAnsweredBySelectingId",
                table: "selectingAnswerQuestionedByAudios",
                column: "audioQuestionAnsweredBySelectingId");

            migrationBuilder.CreateIndex(
                name: "IX_selectingAnswerQuestionedByAudios_UserId",
                table: "selectingAnswerQuestionedByAudios",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectingAnswerQuestionedByPictures_pictureQuestionAnsweredBySelectingId",
                table: "SelectingAnswerQuestionedByPictures",
                column: "pictureQuestionAnsweredBySelectingId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectingAnswerQuestionedByPictures_UserId",
                table: "SelectingAnswerQuestionedByPictures",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectingAnswerQuestionedByTexts_textualQuestionAnsweredBySelectingId",
                table: "SelectingAnswerQuestionedByTexts",
                column: "textualQuestionAnsweredBySelectingId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectingAnswerQuestionedByTexts_UserId",
                table: "SelectingAnswerQuestionedByTexts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectingAnswerQuestionedByVideos_UserId",
                table: "SelectingAnswerQuestionedByVideos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectingAnswerQuestionedByVideos_videoQuestionAnsweredBySelectingId",
                table: "SelectingAnswerQuestionedByVideos",
                column: "videoQuestionAnsweredBySelectingId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCycles_CourseCycleId",
                table: "SubCycles",
                column: "CourseCycleId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TextAnswerQuestionedByAudios_audioQuestionAnsweredBytextId",
                table: "TextAnswerQuestionedByAudios",
                column: "audioQuestionAnsweredBytextId");

            migrationBuilder.CreateIndex(
                name: "IX_TextAnswerQuestionedByAudios_UserId",
                table: "TextAnswerQuestionedByAudios",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TextAnswerQuestionedByPictures_pictureQuestionAnsweredByTextId",
                table: "TextAnswerQuestionedByPictures",
                column: "pictureQuestionAnsweredByTextId");

            migrationBuilder.CreateIndex(
                name: "IX_TextAnswerQuestionedByPictures_UserId",
                table: "TextAnswerQuestionedByPictures",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TextAnswerQuestionedByTexts_textualQuestionAnsweredByTextId",
                table: "TextAnswerQuestionedByTexts",
                column: "textualQuestionAnsweredByTextId");

            migrationBuilder.CreateIndex(
                name: "IX_TextAnswerQuestionedByTexts_UserId",
                table: "TextAnswerQuestionedByTexts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TextAnswerQuestionedByVIdeos_UserId",
                table: "TextAnswerQuestionedByVIdeos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TextAnswerQuestionedByVIdeos_videoQuestionAnsweredByTextId",
                table: "TextAnswerQuestionedByVIdeos",
                column: "videoQuestionAnsweredByTextId");

            migrationBuilder.CreateIndex(
                name: "IX_TextualQuestionAnsweredByAudios_QuestionGroupId",
                table: "TextualQuestionAnsweredByAudios",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TextualQuestionAnsweredBySelectings_QuestionGroupId",
                table: "TextualQuestionAnsweredBySelectings",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TextualQuestionAnsweredByTexts_QuestionGroupId",
                table: "TextualQuestionAnsweredByTexts",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScoreExams_ExamId",
                table: "UserScoreExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScoreExams_UserId",
                table: "UserScoreExams",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoQuestionAnsweredByAudios_QuestionGroupId",
                table: "VideoQuestionAnsweredByAudios",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoQuestionAnsweredBySelectings_QuestionGroupId",
                table: "VideoQuestionAnsweredBySelectings",
                column: "QuestionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoQuestionAnsweredByTexts_QuestionGroupId",
                table: "VideoQuestionAnsweredByTexts",
                column: "QuestionGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AudioAnswerQuestionedByAudios");

            migrationBuilder.DropTable(
                name: "AudioAnswerQuestionedByPictures");

            migrationBuilder.DropTable(
                name: "AudioAnswerQuestionedByTexts");

            migrationBuilder.DropTable(
                name: "AudioAnswerQuestionedByVideos");

            migrationBuilder.DropTable(
                name: "CourseModelConnections");

            migrationBuilder.DropTable(
                name: "ExamCycleConnections");

            migrationBuilder.DropTable(
                name: "QuestionExamConnections");

            migrationBuilder.DropTable(
                name: "RolePermissionConnections");

            migrationBuilder.DropTable(
                name: "selectingAnswerQuestionedByAudios");

            migrationBuilder.DropTable(
                name: "SelectingAnswerQuestionedByPictures");

            migrationBuilder.DropTable(
                name: "SelectingAnswerQuestionedByTexts");

            migrationBuilder.DropTable(
                name: "SelectingAnswerQuestionedByVideos");

            migrationBuilder.DropTable(
                name: "SubCycles");

            migrationBuilder.DropTable(
                name: "SubOrders");

            migrationBuilder.DropTable(
                name: "TextAnswerQuestionedByAudios");

            migrationBuilder.DropTable(
                name: "TextAnswerQuestionedByPictures");

            migrationBuilder.DropTable(
                name: "TextAnswerQuestionedByTexts");

            migrationBuilder.DropTable(
                name: "TextAnswerQuestionedByVIdeos");

            migrationBuilder.DropTable(
                name: "UserScoreExams");

            migrationBuilder.DropTable(
                name: "CourseModels");

            migrationBuilder.DropTable(
                name: "AudioQuestionAnsweredByAudios");

            migrationBuilder.DropTable(
                name: "PictureQuestionAnsweredByAudios");

            migrationBuilder.DropTable(
                name: "TextualQuestionAnsweredByAudios");

            migrationBuilder.DropTable(
                name: "VideoQuestionAnsweredByAudios");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "AudioQuestionAnsweredBySelectings");

            migrationBuilder.DropTable(
                name: "PictureQuestionAnsweredBySelectings");

            migrationBuilder.DropTable(
                name: "TextualQuestionAnsweredBySelectings");

            migrationBuilder.DropTable(
                name: "VideoQuestionAnsweredBySelectings");

            migrationBuilder.DropTable(
                name: "CourseCycles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AudioQuestionAnsweredByTexts");

            migrationBuilder.DropTable(
                name: "PictureQuestionAnsweredByTexts");

            migrationBuilder.DropTable(
                name: "TextualQuestionAnsweredByTexts");

            migrationBuilder.DropTable(
                name: "VideoQuestionAnsweredByTexts");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "CourseDiscounts");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CycleModels");

            migrationBuilder.DropTable(
                name: "OrderDiscounts");

            migrationBuilder.DropTable(
                name: "QuestionGroups");

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
