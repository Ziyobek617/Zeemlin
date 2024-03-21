using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class SchoolLogoAssetMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "ScienceType",
                table: "Teachers",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "SchoolLogoAssets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Path = table.Column<string>(type: "text", nullable: false),
                    UploadedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SchoolId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolLogoAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolLogoAssets_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4011), (byte)12 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4016), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4018), (byte)18 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4020), (byte)12 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4022), (byte)10 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4025), (byte)17 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4029), (byte)0 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4031), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4032), (byte)12 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4035), (byte)16 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4037), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4039), (byte)15 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4041), (byte)13 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4043), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4044), (byte)5 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4046), (byte)18 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4048), (byte)16 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4051), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4053), (byte)12 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4055), (byte)15 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4056), (byte)17 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4058), (byte)13 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4063), (byte)0 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4065), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 43, 10, 625, DateTimeKind.Utc).AddTicks(4067), (byte)20 });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolLogoAssets_SchoolId",
                table: "SchoolLogoAssets",
                column: "SchoolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolLogoAssets");

            migrationBuilder.AlterColumn<int>(
                name: "ScienceType",
                table: "Teachers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint");

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 18, 59, 22, 603, DateTimeKind.Utc).AddTicks(1114));

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
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7282), 3 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7285), 9 });

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
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7293), 8 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7295), 0 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7297), 1 });

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
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7301), 4 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7303), 3 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7304), 2 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7306), 5 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7310), 3 });

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
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7313), 9 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7315), 4 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7317), 1 });

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
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7321), 2 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7322), 8 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7324), 5 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7326), 0 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7327), 3 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedAt", "ScienceType" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 59, 22, 600, DateTimeKind.Utc).AddTicks(7329), 20 });
        }
    }
}
