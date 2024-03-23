using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesUpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonsTable_Lessons_LessonId",
                table: "LessonsTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonsTable",
                table: "LessonsTable");

            migrationBuilder.DropColumn(
                name: "SchoolNumber",
                table: "Teachers");

            migrationBuilder.RenameTable(
                name: "LessonsTable",
                newName: "LessonTables");

            migrationBuilder.RenameColumn(
                name: "GetDate",
                table: "LessonTables",
                newName: "Date");

            migrationBuilder.RenameIndex(
                name: "IX_LessonsTable_LessonId",
                table: "LessonTables",
                newName: "IX_LessonTables_LessonId");

            migrationBuilder.AddColumn<byte>(
                name: "Role",
                table: "TeacherGroups",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<string>(
                name: "PassportSeria",
                table: "SuperAdmins",
                type: "character varying(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<byte>(
                name: "Gender",
                table: "Parents",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<string>(
                name: "PassportSeria",
                table: "Directors",
                type: "character varying(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<long>(
                name: "SuperAdminId",
                table: "Directors",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PassportSeria",
                table: "Admins",
                type: "character varying(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "LessonTables",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Classroom",
                table: "LessonTables",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "LessonTables",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TeacherId",
                table: "LessonTables",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonTables",
                table: "LessonTables",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Orginizer = table.Column<string>(type: "text", nullable: false),
                    EventType = table.Column<byte>(type: "smallint", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Format = table.Column<short>(type: "smallint", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    IsPaid = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    Contact = table.Column<string>(type: "text", nullable: false),
                    OfficialPage = table.Column<string>(type: "text", nullable: true),
                    CreatedByUsername = table.Column<string>(type: "text", nullable: false),
                    UpdaterId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParentStudents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentId = table.Column<long>(type: "bigint", nullable: false),
                    StudentId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParentStudents_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventAssets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Path = table.Column<string>(type: "text", nullable: false),
                    UploadedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventAssets_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SuperAdminId" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6885), null });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SuperAdminId" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6890), null });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SuperAdminId" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6892), null });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SuperAdminId" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6894), null });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SuperAdminId" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6895), null });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SuperAdminId" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6899), null });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7660), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7665), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7668), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7671), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7673), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7677), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7678), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7680), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7682), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7685), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7687), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7691), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7692), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7694), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7695), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7696), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7697), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7700), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7701), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7703), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7704), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7705), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7706), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7708), (byte)2 });

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "Role" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7709), (byte)2 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.CreateIndex(
                name: "IX_Directors_SuperAdminId",
                table: "Directors",
                column: "SuperAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonTables_TeacherId",
                table: "LessonTables",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAssets_EventId",
                table: "EventAssets",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentStudents_ParentId",
                table: "ParentStudents",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentStudents_StudentId",
                table: "ParentStudents",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_SuperAdmins_SuperAdminId",
                table: "Directors",
                column: "SuperAdminId",
                principalTable: "SuperAdmins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonTables_Lessons_LessonId",
                table: "LessonTables",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonTables_Teachers_TeacherId",
                table: "LessonTables",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_SuperAdmins_SuperAdminId",
                table: "Directors");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonTables_Lessons_LessonId",
                table: "LessonTables");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonTables_Teachers_TeacherId",
                table: "LessonTables");

            migrationBuilder.DropTable(
                name: "EventAssets");

            migrationBuilder.DropTable(
                name: "ParentStudents");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Directors_SuperAdminId",
                table: "Directors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonTables",
                table: "LessonTables");

            migrationBuilder.DropIndex(
                name: "IX_LessonTables_TeacherId",
                table: "LessonTables");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "TeacherGroups");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "SuperAdminId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "Classroom",
                table: "LessonTables");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "LessonTables");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "LessonTables");

            migrationBuilder.RenameTable(
                name: "LessonTables",
                newName: "LessonsTable");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "LessonsTable",
                newName: "GetDate");

            migrationBuilder.RenameIndex(
                name: "IX_LessonTables_LessonId",
                table: "LessonsTable",
                newName: "IX_LessonsTable_LessonId");

            migrationBuilder.AddColumn<long>(
                name: "SchoolNumber",
                table: "Teachers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "PassportSeria",
                table: "SuperAdmins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "PassportSeria",
                table: "Directors",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "PassportSeria",
                table: "Admins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "LessonsTable",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonsTable",
                table: "LessonsTable",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4011), 12345L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4016), 12345L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4018), 54321L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4020), 12345L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4022), 54321L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4025), 12345L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4029), 12345L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4031), 54321L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4032), 54321L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4035), 67890L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4037), 67890L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4039), 98765L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4041), 98765L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4043), 67890L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4044), 98765L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4046), 98765L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4048), 24680L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4051), 24680L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4053), 13579L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4055), 13579L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4056), 35791L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4058), 35791L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4063), 46802L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4065), 46802L });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "SchoolNumber" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4067), 46802L });

            migrationBuilder.AddForeignKey(
                name: "FK_LessonsTable_Lessons_LessonId",
                table: "LessonsTable",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
