using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class AssetsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TeacherAssets_TeacherId",
                table: "TeacherAssets");

            migrationBuilder.DropIndex(
                name: "IX_SchoolLogoAssets_SchoolId",
                table: "SchoolLogoAssets");

            migrationBuilder.DropIndex(
                name: "IX_EventAssets_EventId",
                table: "EventAssets");

            migrationBuilder.AddColumn<long>(
                name: "TeacherAssetId",
                table: "Teachers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SchoolLogoAssetId",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "EventAssetId",
                table: "Events",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "QuestionAssets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Path = table.Column<string>(type: "text", nullable: false),
                    UploadedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    QuestionId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAssets_Questiones_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7019), null, (byte)1 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7026), null, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7029), null, (byte)1 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7034), null, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7036), null, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7038), null, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7040), null, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7046), null, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7048), null, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7050), null, (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7052), null, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7056), null, (byte)1 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SchoolLogoAssetId", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7058), null, (byte)1 });

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6901), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6911), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6914), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6916), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6918), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6920), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6922), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6924), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6926), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6929), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6930), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6932), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6933), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6935), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6937), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6938), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6940), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6942), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6944), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6946), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6947), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6949), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6950), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6952), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "TeacherAssetId" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 1, 5, 961, DateTimeKind.Utc).AddTicks(6954), null });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherAssets_TeacherId",
                table: "TeacherAssets",
                column: "TeacherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SchoolLogoAssets_SchoolId",
                table: "SchoolLogoAssets",
                column: "SchoolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventAssets_EventId",
                table: "EventAssets",
                column: "EventId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAssets_QuestionId",
                table: "QuestionAssets",
                column: "QuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAssets");

            migrationBuilder.DropIndex(
                name: "IX_TeacherAssets_TeacherId",
                table: "TeacherAssets");

            migrationBuilder.DropIndex(
                name: "IX_SchoolLogoAssets_SchoolId",
                table: "SchoolLogoAssets");

            migrationBuilder.DropIndex(
                name: "IX_EventAssets_EventId",
                table: "EventAssets");

            migrationBuilder.DropColumn(
                name: "TeacherAssetId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SchoolLogoAssetId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "EventAssetId",
                table: "Events");

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(6899));

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
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7078), (byte)0 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7084), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7087), (byte)0 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7090), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7092), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7095), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7099), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7101), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7131), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7134), (byte)2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7136), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7138), (byte)0 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "SchoolType" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7140), (byte)0 });

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 17, 35, 33, 370, DateTimeKind.Utc).AddTicks(7709));

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
                name: "IX_TeacherAssets_TeacherId",
                table: "TeacherAssets",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolLogoAssets_SchoolId",
                table: "SchoolLogoAssets",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAssets_EventId",
                table: "EventAssets",
                column: "EventId");
        }
    }
}
