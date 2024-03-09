using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class PropertiesDeletedFromAssetsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "TeacherAssets");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "TeacherAssets");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "SchoolAssets");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "SchoolAssets");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "HomeworkAssets");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "HomeworkAssets");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 555, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 19, 14, 46, 553, DateTimeKind.Utc).AddTicks(1707));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "TeacherAssets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "TeacherAssets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "SchoolAssets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "SchoolAssets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "HomeworkAssets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "HomeworkAssets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 259, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 15, 43, 31, 257, DateTimeKind.Utc).AddTicks(1313));
        }
    }
}
