using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewEntitiesAddedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_School_SchoolId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_School_SchoolId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Groups_GroupId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Homework_HomeworkId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_School_SchoolId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Groups_GroupId",
                table: "Homework");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Lessons_LessonId",
                table: "Homework");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Sciences_ScienceId",
                table: "Homework");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Teachers_TeacherId",
                table: "Homework");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkAssets_Groups_GroupId",
                table: "HomeworkAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkAssets_Homework_HomeworkId",
                table: "HomeworkAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkAssets_Teachers_TeacherId",
                table: "HomeworkAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonsTable_Groups_GroupId",
                table: "LessonsTable");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonsTable_Teachers_TeacherId",
                table: "LessonsTable");

            migrationBuilder.DropForeignKey(
                name: "FK_School_Directors_DirectorId",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_School_SuperAdmins_SuperAdminId",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Groups_GroupId",
                table: "StudentGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Students_StudentId",
                table: "StudentGroup");

            migrationBuilder.DropTable(
                name: "ScienceTeacher");

            migrationBuilder.DropTable(
                name: "Sciences");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_PhoneNumber",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherGroups",
                table: "TeacherGroups");

            migrationBuilder.DropIndex(
                name: "IX_LessonsTable_GroupId",
                table: "LessonsTable");

            migrationBuilder.DropIndex(
                name: "IX_HomeworkAssets_GroupId",
                table: "HomeworkAssets");

            migrationBuilder.DropIndex(
                name: "IX_HomeworkAssets_TeacherId",
                table: "HomeworkAssets");

            migrationBuilder.DropIndex(
                name: "IX_Groups_SchoolId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Grades_GroupId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_HomeworkId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_StudentId",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentGroup",
                table: "StudentGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_School",
                table: "School");

            migrationBuilder.DropIndex(
                name: "IX_School_SchoolNumber",
                table: "School");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Homework",
                table: "Homework");

            migrationBuilder.DropIndex(
                name: "IX_Homework_GroupId",
                table: "Homework");

            migrationBuilder.DropIndex(
                name: "IX_Homework_ScienceId",
                table: "Homework");

            migrationBuilder.DropIndex(
                name: "IX_Homework_TeacherId",
                table: "Homework");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "LessonsTable");

            migrationBuilder.DropColumn(
                name: "ScienceType",
                table: "LessonAttendances");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "HomeworkAssets");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "HomeworkAssets");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "HomeworkId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Homework");

            migrationBuilder.DropColumn(
                name: "ScienceId",
                table: "Homework");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Homework");

            migrationBuilder.RenameTable(
                name: "StudentGroup",
                newName: "StudentGroups");

            migrationBuilder.RenameTable(
                name: "School",
                newName: "Schools");

            migrationBuilder.RenameTable(
                name: "Homework",
                newName: "Homeworks");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "LessonsTable",
                newName: "LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_LessonsTable_TeacherId",
                table: "LessonsTable",
                newName: "IX_LessonsTable_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGroup_StudentId",
                table: "StudentGroups",
                newName: "IX_StudentGroups_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGroup_GroupId",
                table: "StudentGroups",
                newName: "IX_StudentGroups_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_School_SuperAdminId",
                table: "Schools",
                newName: "IX_Schools_SuperAdminId");

            migrationBuilder.RenameIndex(
                name: "IX_School_DirectorId",
                table: "Schools",
                newName: "IX_Schools_DirectorId");

            migrationBuilder.RenameIndex(
                name: "IX_Homework_LessonId",
                table: "Homeworks",
                newName: "IX_Homeworks_LessonId");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "TeacherGroups",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherGroups",
                table: "TeacherGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentGroups",
                table: "StudentGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schools",
                table: "Schools",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    SchoolId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolAssets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Path = table.Column<string>(type: "text", nullable: false),
                    ContentType = table.Column<string>(type: "text", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    UploadedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SchoolId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolAssets_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questiones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Difficulty = table.Column<byte>(type: "smallint", nullable: false),
                    Type = table.Column<byte>(type: "smallint", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    QuizId = table.Column<long>(type: "bigint", nullable: false),
                    TeacherId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questiones_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questiones_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    IsCorrect = table.Column<bool>(type: "boolean", nullable: false),
                    QuestionId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questiones_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherGroups_TeacherId",
                table: "TeacherGroups",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_UserId",
                table: "Grades",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questiones_QuizId",
                table: "Questiones",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Questiones_TeacherId",
                table: "Questiones",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_SchoolId",
                table: "Quizzes",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolAssets_SchoolId",
                table: "SchoolAssets",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Schools_SchoolId",
                table: "Admins",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Schools_SchoolId",
                table: "Courses",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_UserId",
                table: "Grades",
                column: "UserId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkAssets_Homeworks_HomeworkId",
                table: "HomeworkAssets",
                column: "HomeworkId",
                principalTable: "Homeworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Lessons_LessonId",
                table: "Homeworks",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonsTable_Lessons_LessonId",
                table: "LessonsTable",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Directors_DirectorId",
                table: "Schools",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_SuperAdmins_SuperAdminId",
                table: "Schools",
                column: "SuperAdminId",
                principalTable: "SuperAdmins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroups_Groups_GroupId",
                table: "StudentGroups",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroups_Students_StudentId",
                table: "StudentGroups",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Schools_SchoolId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Schools_SchoolId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_UserId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkAssets_Homeworks_HomeworkId",
                table: "HomeworkAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Lessons_LessonId",
                table: "Homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonsTable_Lessons_LessonId",
                table: "LessonsTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Directors_DirectorId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_SuperAdmins_SuperAdminId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroups_Groups_GroupId",
                table: "StudentGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroups_Students_StudentId",
                table: "StudentGroups");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "SchoolAssets");

            migrationBuilder.DropTable(
                name: "Questiones");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherGroups",
                table: "TeacherGroups");

            migrationBuilder.DropIndex(
                name: "IX_TeacherGroups_TeacherId",
                table: "TeacherGroups");

            migrationBuilder.DropIndex(
                name: "IX_Grades_UserId",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentGroups",
                table: "StudentGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schools",
                table: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks");

            migrationBuilder.RenameTable(
                name: "StudentGroups",
                newName: "StudentGroup");

            migrationBuilder.RenameTable(
                name: "Schools",
                newName: "School");

            migrationBuilder.RenameTable(
                name: "Homeworks",
                newName: "Homework");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "LessonsTable",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_LessonsTable_LessonId",
                table: "LessonsTable",
                newName: "IX_LessonsTable_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGroups_StudentId",
                table: "StudentGroup",
                newName: "IX_StudentGroup_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGroups_GroupId",
                table: "StudentGroup",
                newName: "IX_StudentGroup_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Schools_SuperAdminId",
                table: "School",
                newName: "IX_School_SuperAdminId");

            migrationBuilder.RenameIndex(
                name: "IX_Schools_DirectorId",
                table: "School",
                newName: "IX_School_DirectorId");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_LessonId",
                table: "Homework",
                newName: "IX_Homework_LessonId");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "TeacherGroups",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "GroupId",
                table: "LessonsTable",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "ScienceType",
                table: "LessonAttendances",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "GroupId",
                table: "HomeworkAssets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TeacherId",
                table: "HomeworkAssets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SchoolId",
                table: "Groups",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "GroupId",
                table: "Grades",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "HomeworkId",
                table: "Grades",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "Grades",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "GroupId",
                table: "Homework",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ScienceId",
                table: "Homework",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TeacherId",
                table: "Homework",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherGroups",
                table: "TeacherGroups",
                columns: new[] { "TeacherId", "GroupId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentGroup",
                table: "StudentGroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_School",
                table: "School",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Homework",
                table: "Homework",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Sciences",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ScienceType = table.Column<int>(type: "integer", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sciences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScienceTeacher",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScienceId = table.Column<long>(type: "bigint", nullable: false),
                    TeacherId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScienceTeacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScienceTeacher_Sciences_ScienceId",
                        column: x => x.ScienceId,
                        principalTable: "Sciences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScienceTeacher_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_PhoneNumber",
                table: "Teachers",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LessonsTable_GroupId",
                table: "LessonsTable",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkAssets_GroupId",
                table: "HomeworkAssets",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkAssets_TeacherId",
                table: "HomeworkAssets",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SchoolId",
                table: "Groups",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_GroupId",
                table: "Grades",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_HomeworkId",
                table: "Grades",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_School_SchoolNumber",
                table: "School",
                column: "SchoolNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Homework_GroupId",
                table: "Homework",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Homework_ScienceId",
                table: "Homework",
                column: "ScienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Homework_TeacherId",
                table: "Homework",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ScienceTeacher_ScienceId",
                table: "ScienceTeacher",
                column: "ScienceId");

            migrationBuilder.CreateIndex(
                name: "IX_ScienceTeacher_TeacherId",
                table: "ScienceTeacher",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_School_SchoolId",
                table: "Admins",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_School_SchoolId",
                table: "Courses",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Groups_GroupId",
                table: "Grades",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Homework_HomeworkId",
                table: "Grades",
                column: "HomeworkId",
                principalTable: "Homework",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_School_SchoolId",
                table: "Groups",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Groups_GroupId",
                table: "Homework",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Lessons_LessonId",
                table: "Homework",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Sciences_ScienceId",
                table: "Homework",
                column: "ScienceId",
                principalTable: "Sciences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Teachers_TeacherId",
                table: "Homework",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkAssets_Groups_GroupId",
                table: "HomeworkAssets",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkAssets_Homework_HomeworkId",
                table: "HomeworkAssets",
                column: "HomeworkId",
                principalTable: "Homework",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkAssets_Teachers_TeacherId",
                table: "HomeworkAssets",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonsTable_Groups_GroupId",
                table: "LessonsTable",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonsTable_Teachers_TeacherId",
                table: "LessonsTable",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_School_Directors_DirectorId",
                table: "School",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_School_SuperAdmins_SuperAdminId",
                table: "School",
                column: "SuperAdminId",
                principalTable: "SuperAdmins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Groups_GroupId",
                table: "StudentGroup",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Students_StudentId",
                table: "StudentGroup",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
