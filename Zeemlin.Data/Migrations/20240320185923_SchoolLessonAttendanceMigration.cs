using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class SchoolLessonAttendanceMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "LessonAttendances");

            migrationBuilder.DropColumn(
                name: "TeacherName",
                table: "LessonAttendances");

            migrationBuilder.AddColumn<byte>(
                name: "SchoolType",
                table: "Schools",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Name", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1082), "Inter-Nation", (byte)0 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Name", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1090), "Ingliz olami", "Cambridge Edu", (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1094), (byte)0 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1096), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1098), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1101), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1103), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1105), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1107), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1109), (byte)2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1111), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1113), (byte)0 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1114), (byte)0 });

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7275), 11 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7287), 11 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7290), 17 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7298), 11 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7311), 12 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7319), 11 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7329), 20 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolType",
                table: "Schools");

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "LessonAttendances",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeacherName",
                table: "LessonAttendances",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8658), "Toshkent Xalqaro Maktabi" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Name" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8669), "Yuqori malakali mutaxassislar tayyorlaydigan oliy ta'lim muassasasi", "Samarqand Texnologiya Instituti" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(487), 10 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(498), 10 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(499), 15 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(507), 10 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(518), 11 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(525), 10 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(535), 17 });
        }
    }
}
