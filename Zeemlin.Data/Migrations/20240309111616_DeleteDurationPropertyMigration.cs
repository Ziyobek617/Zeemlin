using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeleteDurationPropertyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Lessons");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 749, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 11, 16, 15, 747, DateTimeKind.Utc).AddTicks(5260));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Lessons",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8149), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8163), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8167), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8169), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8172), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8176), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8179), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8181), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8183), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8186), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8189), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8191), new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 907, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 9, 10, 44, 22, 905, DateTimeKind.Utc).AddTicks(3648));
        }
    }
}
