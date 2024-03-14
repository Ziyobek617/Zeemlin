using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhoneNumberDirectorMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Directors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9725), "+998904567890" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9732), "+998904567890" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9735), "+998904567890" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9737), "+998904567890" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9739), "+998904567890" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9742), "+998904567890" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 817, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 11, 16, 32, 814, DateTimeKind.Utc).AddTicks(9891));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Directors");

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
    }
}
