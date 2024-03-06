using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Zeemlin.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedBugSeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "Gender", "LastName", "PassportSeria", "Password", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8900), "olimjon.torayev@director.com", "Olimjon", (byte)1, "To'rayev", "AB123456", "hashed_password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "director1" },
                    { 2L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8906), "nodira.xolmirzayeva@director.com", "Nodira", (byte)2, "Xolmirzayeva", "CD789012", "hashed_password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "director2" },
                    { 3L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8908), "sarvar.qosimov@director.com", "Sarvar", (byte)1, "Qosimov", "EF345678", "hashed_password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "director3" },
                    { 4L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8911), "malika.azizova@director.com", "Malika", (byte)2, "Azizova", "GH567890", "hashed_password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "director4" },
                    { 5L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8913), "islom.karimov@director.com", "Islom", (byte)1, "Karimov", "IJ789012", "hashed_password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "director5" },
                    { 6L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8916), "ikcmwopv@director.com", "mcpw", (byte)1, "cmla", "IJ785212", "hashed_password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "director5" }
                });

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Email", "FirstName", "Gender", "LastName" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8570), "shahnozaodilova@gmail.com", "Shahnoza", (byte)2, "Odilova" });

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8579), "moxi05@gmail.com", "Moxinur", "Zokirova" });

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "Gender", "LastName", "PassportSeria", "Password", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 3L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8581), "akbarov@gmail.com", "Muhammadjon", (byte)1, "Akbarov", "AB123458", "hashed_password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin3" },
                    { 4L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8583), "ruxshona0@gmail.com", "Ruxshona", (byte)2, "Nodirova", "CD789013", "hashed_password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin4" },
                    { 5L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8586), "kimdir@gmail.com", "Kimdir", (byte)2, "Bilmiman", "CD789014", "hashed_password", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin4" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CallCenter", "Country", "CreatedAt", "Description", "DirectorId", "DistrictName", "EmailCenter", "GeneralAddressMFY", "Name", "Region", "SchoolNumber", "StreetName", "SuperAdminId", "UpdatedAt", "Website" },
                values: new object[,]
                {
                    { 1L, "+998900000001", "O'zbekiston", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4771), "Xalqaro standartlarga asoslangan innovatsion ta'lim muassasasi", 1L, "Mirzo Ulug'bek", "TXM@school.com", "Uch Qahramon MFY", "Toshkent Xalqaro Maktabi", 2, 12345L, "Bog'ishamol ko'chasi", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TXM.com" },
                    { 2L, "+998900000002", "O'zbekiston", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4783), "Yuqori malakali mutaxassislar tayyorlaydigan oliy ta'lim muassasasi", 2L, "Eskishahar", "STI@school.com", "Xo'ja Ahror Vali MFY", "Samarqand Texnologiya Instituti", 11, 54321L, "Registon ko'chasi", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "STI.com" },
                    { 3L, "+998900000003", "O'zbekiston", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4787), "Pedagogika sohasida yuqori malakali mutaxassislar tayyorlaydigan oliy ta'lim muassasasi", 3L, "Shahriston", "API@school.com", "Pedagogika instituti", "Andijon Pedagogika Instituti", 3, 67890L, "Pedagogika ko'chasi", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "API.com" },
                    { 4L, "+998900000004", "O'zbekiston", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4789), "Oliy ta'lim sohasida yuqori malakali mutaxassislar tayyorlaydigan davlat universiteti", 4L, "Namangan shahri", "NDU@school.com", "Universitet", "Namangan Davlat Universiteti", 4, 98765L, "Universitet ko'chasi", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NDU.com" },
                    { 5L, "+998900000013", "Uzbekistan", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4791), "Center providing language training services.", 3L, "Yunusabad", "info@tltraining.com", "Language Training Center", "Tashkent Language Training Center", 1, 13579L, "Language Street", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://tltraining.com" },
                    { 6L, "+998900000014", "Uzbekistan", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4795), "Center offering computer training courses.", 4L, "Samarqand shahri", "info@sctc.uz", "Computer Training Center", "Samarkand Computer Training Center", 11, 24680L, "Computer Street", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://sctc.uz" },
                    { 7L, "+998900000015", "Uzbekistan", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4860), "Fitness center offering various training programs.", 1L, "Navoiy shahri", "info@navfit.com", "Fitness Training Center", "Navoiy Fitness Training Center", 9, 35791L, "Fitness Street", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://navfit.com" },
                    { 8L, "+998900000016", "Uzbekistan", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4863), "Center specializing in photography training.", 2L, "Termiz shahri", "info@sptc.uz", "Photography Training Center", "Surxondaryo Photography Training Center", 12, 46802L, "Photography Street", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://sptc.uz" },
                    { 9L, "+998900000017", "Uzbekistan", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4865), "Center providing language training services.", 3L, "Yunusabad", "info@tltraining.com", "Yunusabad MFY", "Tashkent Language Training Center", 1, 13579L, "Mustaqillik Avenue", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://tltraining.com" },
                    { 10L, "+998900000018", "Uzbekistan", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4868), "Center offering computer training courses.", 4L, "Samarqand shahri", "info@sctc.uz", "Samarqand MFY", "Samarkand Computer Training Center", 11, 24680L, "Amir Temur Street", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://sctc.uz" },
                    { 11L, "+998900000019", "Uzbekistan", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4870), "Fitness center offering various training programs.", 1L, "Navoiy shahri", "info@navfit.com", "Navoiy MFY", "Navoiy Fitness Training Center", 9, 35791L, "Olmazor Street", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://navfit.com" },
                    { 12L, "+998900000020", "Uzbekistan", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4873), "Center specializing in photography training.", 5L, "Termiz shahri", "info@sptc.uz", "Termiz MFY", "Surxondaryo Photography Training Center", 12, 46802L, "Shaxrisabz Street", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://sptc.uz" },
                    { 13L, "+998900000021", "Uzbekistan", new DateTime(2024, 3, 6, 20, 6, 11, 920, DateTimeKind.Utc).AddTicks(4875), "Center specializing in photography training.", 5L, "Termiz shahri", "info@sptc.uz", "Termiz MFY", "Surxondaryo Photography Training Center", 12, 4680L, "Shaxrisabz Street", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://sptc.uz" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "Gender", "LastName", "PassportSeria", "Password", "SchoolId", "SuperAdminId", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8685), "johndoe@admin1.com", "John", (byte)1, "Doe", "AB123456", "hashed_password", 1L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school1" },
                    { 2L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8697), "janesmith@admin2.com", "Jane", (byte)2, "Smith", "CD789012", "hashed_password", 1L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school1" },
                    { 3L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8699), "michaeljohnson@admin1.com", "Michael", (byte)1, "Johnson", "EF345678", "hashed_password", 2L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school2" },
                    { 4L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8709), "emmadavis@admin2.com", "Emma", (byte)2, "Davis", "GH901234", "hashed_password", 2L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school2" },
                    { 5L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8711), "williambrown@admin1.com", "William", (byte)1, "Brown", "IJ567890", "hashed_password", 3L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school3" },
                    { 6L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8714), "oliviataylor@admin2.com", "Olivia", (byte)2, "Taylor", "KL123456", "hashed_password", 3L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school3" },
                    { 7L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8727), "davidwilson@admin1.com", "David", (byte)1, "Wilson", "MN789012", "hashed_password", 4L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school4" },
                    { 8L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8729), "sophiamartinez@admin2.com", "Sophia", (byte)2, "Martinez", "OP345678", "hashed_password", 4L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school4" },
                    { 9L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8731), "jamesanderson@admin1.com", "James", (byte)1, "Anderson", "QR901234", "hashed_password", 5L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school5" },
                    { 10L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8734), "avahernandez@admin2.com", "Ava", (byte)2, "Hernandez", "ST567890", "hashed_password", 5L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school5" },
                    { 11L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8736), "benjaminyoung@admin1.com", "Benjamin", (byte)1, "Young", "UV123456", "hashed_password", 6L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school6" },
                    { 12L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8738), "mialopez@admin2.com", "Mia", (byte)2, "Lopez", "WX789012", "hashed_password", 6L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school6" },
                    { 13L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8739), "danielgonzalez@admin1.com", "Daniel", (byte)1, "Gonzalez", "YZ345678", "hashed_password", 7L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school7" },
                    { 14L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8741), "isabellaperez@admin2.com", "Isabella", (byte)2, "Perez", "AB901234", "hashed_password", 7L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school7" },
                    { 15L, new DateTime(2024, 3, 7, 1, 6, 11, 917, DateTimeKind.Utc).AddTicks(8747), "islom.karimov@admin1.com", "Islom", (byte)1, "Karimov", "MN567890", "hashed_password", 8L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school4" },
                    { 16L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8803), "noziman.yoldosheva@admin2.com", "Nozima", (byte)2, "Yo'ldosheva", "OP123456", "hashed_password", 8L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school4" },
                    { 17L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8804), "ethanmoore@admin1.com", "Ethan", (byte)1, "Moore", "CD901234", "hashed_password", 9L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school9" },
                    { 18L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8807), "charlotterogers@admin2.com", "Charlotte", (byte)2, "Rogers", "EF567890", "hashed_password", 9L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school9" },
                    { 19L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8809), "alexanderscott@admin1.com", "Alexander", (byte)1, "Scott", "GH123456", "hashed_password", 10L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school10" },
                    { 20L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8811), "ameliagomez@admin2.com", "Amelia", (byte)2, "Gomez", "IJ789012", "hashed_password", 10L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school10" },
                    { 21L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8812), "henrywright@admin1.com", "Henry", (byte)1, "Wright", "KL345678", "hashed_password", 11L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school11" },
                    { 22L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8814), "sophieflores@admin2.com", "Sophie", (byte)2, "Flores", "MN901234", "hashed_password", 11L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school11" },
                    { 23L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8816), "liamsanchez@admin1.com", "Liam", (byte)1, "Sanchez", "OP567890", "hashed_password", 12L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1_school12" },
                    { 24L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8818), "gracechang@admin2.com", "Grace", (byte)2, "Chang", "QR123456", "hashed_password", 12L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2_school12" },
                    { 25L, new DateTime(2024, 3, 6, 20, 6, 11, 917, DateTimeKind.Utc).AddTicks(8826), "cmwp@admin2.com", "mps", (byte)2, "cmwp", "QR123456", "hashed_password", 13L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin3_school12" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Email", "FirstName", "Gender", "LastName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", "John", (byte)1, "Doe" });

            migrationBuilder.UpdateData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janesmith@example.com", "Jane", "Smith" });
        }
    }
}
