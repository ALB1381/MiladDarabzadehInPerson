using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiladDarabzadeh.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig0000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseCycls_CourseDiscounts_DiscountId",
                table: "CourseCycls");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseCycls_Courses_CourseId",
                table: "CourseCycls");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseCycls_CycleModels_CycleModelId",
                table: "CourseCycls");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelConnections_CourseModels_ModelId",
                table: "ModelConnections");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelConnections_Courses_CourseId",
                table: "ModelConnections");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCycls_CourseCycls_CourseCycleId",
                table: "SubCycls");

            migrationBuilder.DropForeignKey(
                name: "FK_SubOrders_CourseCycls_CycleId",
                table: "SubOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCycls",
                table: "SubCycls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModelConnections",
                table: "ModelConnections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseCycls",
                table: "CourseCycls");

            migrationBuilder.RenameTable(
                name: "SubCycls",
                newName: "SubCycles");

            migrationBuilder.RenameTable(
                name: "ModelConnections",
                newName: "CourseModelConnections");

            migrationBuilder.RenameTable(
                name: "CourseCycls",
                newName: "CourseCycles");

            migrationBuilder.RenameIndex(
                name: "IX_SubCycls_CourseCycleId",
                table: "SubCycles",
                newName: "IX_SubCycles_CourseCycleId");

            migrationBuilder.RenameIndex(
                name: "IX_ModelConnections_ModelId",
                table: "CourseModelConnections",
                newName: "IX_CourseModelConnections_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_ModelConnections_CourseId",
                table: "CourseModelConnections",
                newName: "IX_CourseModelConnections_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseCycls_DiscountId",
                table: "CourseCycles",
                newName: "IX_CourseCycles_DiscountId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseCycls_CycleModelId",
                table: "CourseCycles",
                newName: "IX_CourseCycles_CycleModelId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseCycls_CourseId",
                table: "CourseCycles",
                newName: "IX_CourseCycles_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCycles",
                table: "SubCycles",
                column: "SubCycleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseModelConnections",
                table: "CourseModelConnections",
                column: "CMCId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseCycles",
                table: "CourseCycles",
                column: "CycleId");

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserRegisterDate",
                value: new DateTime(2024, 8, 17, 7, 24, 2, 114, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "UserRegisterDate",
                value: new DateTime(2024, 8, 17, 7, 24, 2, 114, DateTimeKind.Local).AddTicks(1643));

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
                name: "IX_ExamCycleConnections_CycleId",
                table: "ExamCycleConnections",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamCycleConnections_ExamId",
                table: "ExamCycleConnections",
                column: "ExamId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CourseCycles_CourseDiscounts_DiscountId",
                table: "CourseCycles",
                column: "DiscountId",
                principalTable: "CourseDiscounts",
                principalColumn: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseCycles_Courses_CourseId",
                table: "CourseCycles",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseCycles_CycleModels_CycleModelId",
                table: "CourseCycles",
                column: "CycleModelId",
                principalTable: "CycleModels",
                principalColumn: "CycleModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseModelConnections_CourseModels_ModelId",
                table: "CourseModelConnections",
                column: "ModelId",
                principalTable: "CourseModels",
                principalColumn: "CourseModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseModelConnections_Courses_CourseId",
                table: "CourseModelConnections",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCycles_CourseCycles_CourseCycleId",
                table: "SubCycles",
                column: "CourseCycleId",
                principalTable: "CourseCycles",
                principalColumn: "CycleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubOrders_CourseCycles_CycleId",
                table: "SubOrders",
                column: "CycleId",
                principalTable: "CourseCycles",
                principalColumn: "CycleId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseCycles_CourseDiscounts_DiscountId",
                table: "CourseCycles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseCycles_Courses_CourseId",
                table: "CourseCycles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseCycles_CycleModels_CycleModelId",
                table: "CourseCycles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseModelConnections_CourseModels_ModelId",
                table: "CourseModelConnections");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseModelConnections_Courses_CourseId",
                table: "CourseModelConnections");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCycles_CourseCycles_CourseCycleId",
                table: "SubCycles");

            migrationBuilder.DropForeignKey(
                name: "FK_SubOrders_CourseCycles_CycleId",
                table: "SubOrders");

            migrationBuilder.DropTable(
                name: "AudioAnswerQuestionedByAudios");

            migrationBuilder.DropTable(
                name: "AudioAnswerQuestionedByPictures");

            migrationBuilder.DropTable(
                name: "AudioAnswerQuestionedByTexts");

            migrationBuilder.DropTable(
                name: "AudioAnswerQuestionedByVideos");

            migrationBuilder.DropTable(
                name: "ExamCycleConnections");

            migrationBuilder.DropTable(
                name: "QuestionExamConnections");

            migrationBuilder.DropTable(
                name: "selectingAnswerQuestionedByAudios");

            migrationBuilder.DropTable(
                name: "SelectingAnswerQuestionedByPictures");

            migrationBuilder.DropTable(
                name: "SelectingAnswerQuestionedByTexts");

            migrationBuilder.DropTable(
                name: "SelectingAnswerQuestionedByVideos");

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
                name: "AudioQuestionAnsweredByAudios");

            migrationBuilder.DropTable(
                name: "PictureQuestionAnsweredByAudios");

            migrationBuilder.DropTable(
                name: "TextualQuestionAnsweredByAudios");

            migrationBuilder.DropTable(
                name: "VideoQuestionAnsweredByAudios");

            migrationBuilder.DropTable(
                name: "AudioQuestionAnsweredBySelectings");

            migrationBuilder.DropTable(
                name: "PictureQuestionAnsweredBySelectings");

            migrationBuilder.DropTable(
                name: "TextualQuestionAnsweredBySelectings");

            migrationBuilder.DropTable(
                name: "VideoQuestionAnsweredBySelectings");

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
                name: "QuestionGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCycles",
                table: "SubCycles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseModelConnections",
                table: "CourseModelConnections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseCycles",
                table: "CourseCycles");

            migrationBuilder.RenameTable(
                name: "SubCycles",
                newName: "SubCycls");

            migrationBuilder.RenameTable(
                name: "CourseModelConnections",
                newName: "ModelConnections");

            migrationBuilder.RenameTable(
                name: "CourseCycles",
                newName: "CourseCycls");

            migrationBuilder.RenameIndex(
                name: "IX_SubCycles_CourseCycleId",
                table: "SubCycls",
                newName: "IX_SubCycls_CourseCycleId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseModelConnections_ModelId",
                table: "ModelConnections",
                newName: "IX_ModelConnections_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseModelConnections_CourseId",
                table: "ModelConnections",
                newName: "IX_ModelConnections_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseCycles_DiscountId",
                table: "CourseCycls",
                newName: "IX_CourseCycls_DiscountId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseCycles_CycleModelId",
                table: "CourseCycls",
                newName: "IX_CourseCycls_CycleModelId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseCycles_CourseId",
                table: "CourseCycls",
                newName: "IX_CourseCycls_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCycls",
                table: "SubCycls",
                column: "SubCycleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModelConnections",
                table: "ModelConnections",
                column: "CMCId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseCycls",
                table: "CourseCycls",
                column: "CycleId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CourseCycls_CourseDiscounts_DiscountId",
                table: "CourseCycls",
                column: "DiscountId",
                principalTable: "CourseDiscounts",
                principalColumn: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseCycls_Courses_CourseId",
                table: "CourseCycls",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseCycls_CycleModels_CycleModelId",
                table: "CourseCycls",
                column: "CycleModelId",
                principalTable: "CycleModels",
                principalColumn: "CycleModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelConnections_CourseModels_ModelId",
                table: "ModelConnections",
                column: "ModelId",
                principalTable: "CourseModels",
                principalColumn: "CourseModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelConnections_Courses_CourseId",
                table: "ModelConnections",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCycls_CourseCycls_CourseCycleId",
                table: "SubCycls",
                column: "CourseCycleId",
                principalTable: "CourseCycls",
                principalColumn: "CycleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubOrders_CourseCycls_CycleId",
                table: "SubOrders",
                column: "CycleId",
                principalTable: "CourseCycls",
                principalColumn: "CycleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
