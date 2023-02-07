using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobBoardManagement.Server.Migrations
{
    public partial class AddApplicationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 36, 188, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 2, 7, 12, 31, 36, 189, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 36, 189, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 2, 7, 12, 31, 36, 189, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "JLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 36, 190, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 2, 7, 12, 31, 36, 190, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "JLocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 36, 190, DateTimeKind.Local).AddTicks(5765), new DateTime(2023, 2, 7, 12, 31, 36, 190, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 36, 190, DateTimeKind.Local).AddTicks(9099), new DateTime(2023, 2, 7, 12, 31, 36, 190, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 36, 190, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 2, 7, 12, 31, 36, 190, DateTimeKind.Local).AddTicks(9112) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 10, 490, DateTimeKind.Local).AddTicks(7398), new DateTime(2023, 2, 7, 12, 31, 10, 491, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 10, 491, DateTimeKind.Local).AddTicks(7659), new DateTime(2023, 2, 7, 12, 31, 10, 491, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "JLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 10, 493, DateTimeKind.Local).AddTicks(171), new DateTime(2023, 2, 7, 12, 31, 10, 493, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "JLocations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 10, 493, DateTimeKind.Local).AddTicks(182), new DateTime(2023, 2, 7, 12, 31, 10, 493, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 10, 493, DateTimeKind.Local).AddTicks(3322), new DateTime(2023, 2, 7, 12, 31, 10, 493, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2023, 2, 7, 12, 31, 10, 493, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 2, 7, 12, 31, 10, 493, DateTimeKind.Local).AddTicks(3334) });
        }
    }
}
