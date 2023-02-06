using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobBoardManagement.Server.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 518, DateTimeKind.Local).AddTicks(7295), new DateTime(2023, 2, 2, 12, 54, 51, 520, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 520, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 2, 2, 12, 54, 51, 520, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 521, DateTimeKind.Local).AddTicks(7143), new DateTime(2023, 2, 2, 12, 54, 51, 521, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 521, DateTimeKind.Local).AddTicks(7158), new DateTime(2023, 2, 2, 12, 54, 51, 521, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "JLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "JLocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(9994), new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(5591), new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(2242), new DateTime(2023, 2, 2, 12, 54, 51, 522, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 523, DateTimeKind.Local).AddTicks(5802), new DateTime(2023, 2, 2, 12, 54, 51, 523, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 523, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 2, 2, 12, 54, 51, 523, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 524, DateTimeKind.Local).AddTicks(93), new DateTime(2023, 2, 2, 12, 54, 51, 524, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 524, DateTimeKind.Local).AddTicks(107), new DateTime(2023, 2, 2, 12, 54, 51, 524, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 524, DateTimeKind.Local).AddTicks(3513), new DateTime(2023, 2, 2, 12, 54, 51, 524, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 54, 51, 524, DateTimeKind.Local).AddTicks(3526), new DateTime(2023, 2, 2, 12, 54, 51, 524, DateTimeKind.Local).AddTicks(3529) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 543, DateTimeKind.Local).AddTicks(5398), new DateTime(2023, 2, 2, 12, 45, 10, 544, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 544, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 2, 2, 12, 45, 10, 544, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 546, DateTimeKind.Local).AddTicks(7715), new DateTime(2023, 2, 2, 12, 45, 10, 546, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 546, DateTimeKind.Local).AddTicks(7731), new DateTime(2023, 2, 2, 12, 45, 10, 546, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "JLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 548, DateTimeKind.Local).AddTicks(3382), new DateTime(2023, 2, 2, 12, 45, 10, 548, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "JLocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 548, DateTimeKind.Local).AddTicks(3399), new DateTime(2023, 2, 2, 12, 45, 10, 548, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 547, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 2, 2, 12, 45, 10, 547, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 547, DateTimeKind.Local).AddTicks(8652), new DateTime(2023, 2, 2, 12, 45, 10, 547, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 547, DateTimeKind.Local).AddTicks(4522), new DateTime(2023, 2, 2, 12, 45, 10, 547, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 547, DateTimeKind.Local).AddTicks(4539), new DateTime(2023, 2, 2, 12, 45, 10, 547, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 548, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 2, 2, 12, 45, 10, 548, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 548, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 2, 2, 12, 45, 10, 548, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 549, DateTimeKind.Local).AddTicks(3201), new DateTime(2023, 2, 2, 12, 45, 10, 549, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 549, DateTimeKind.Local).AddTicks(3215), new DateTime(2023, 2, 2, 12, 45, 10, 549, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 549, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 2, 2, 12, 45, 10, 549, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 2, 12, 45, 10, 549, DateTimeKind.Local).AddTicks(7375), new DateTime(2023, 2, 2, 12, 45, 10, 549, DateTimeKind.Local).AddTicks(7377) });
        }
    }
}
