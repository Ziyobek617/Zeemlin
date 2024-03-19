using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class CourseClassMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuildingNumber",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "EntranceNumber",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Floor",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "StudentUniqueId",
                table: "Parents");

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8786), 48651 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8790), 74586 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8792), 48651 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8793), 48651 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8795), 54861 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8797), 48651 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8798), 10000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8799), 10000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8800), 153889 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8802), 485325 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8803), 489615 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8804), 98465 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8806), 84650 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8807), 10000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8808), 10000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8809), 10000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8810), 78245 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8812), 40978 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8813), 48740 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8814), 48658 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8815), 755407 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8817), 4150 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8818), 4568 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8819), 86000 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "price" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8820), 1000 });

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 147, DateTimeKind.Utc).AddTicks(8669));

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(487));

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(499));

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(507));

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(518));

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(525));

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 10, 11, 13, 146, DateTimeKind.Utc).AddTicks(535));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "Courses");

            migrationBuilder.AddColumn<short>(
                name: "BuildingNumber",
                table: "Parents",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "EntranceNumber",
                table: "Parents",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "Floor",
                table: "Parents",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "Parents",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentUniqueId",
                table: "Parents",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 740, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 46, 54, 738, DateTimeKind.Utc).AddTicks(6473));
        }
    }
}
