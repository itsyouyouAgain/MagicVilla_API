using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers1",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers1", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 49, 11, 805, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 49, 11, 805, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 49, 11, 805, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 49, 11, 805, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 15, 49, 11, 805, DateTimeKind.Local).AddTicks(7610));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers1");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 16, 44, 9, 504, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 16, 44, 9, 504, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 16, 44, 9, 504, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 16, 44, 9, 504, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 16, 44, 9, 504, DateTimeKind.Local).AddTicks(1220));
        }
    }
}
