using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTablee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 8, 21, 202, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 8, 21, 202, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 8, 21, 202, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 8, 21, 202, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 8, 21, 202, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers1_VillaID",
                table: "VillaNumbers1",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers1_Villas_VillaID",
                table: "VillaNumbers1",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers1_Villas_VillaID",
                table: "VillaNumbers1");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers1_VillaID",
                table: "VillaNumbers1");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers1");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 6, 35, 976, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 6, 35, 976, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 6, 35, 976, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 6, 35, 976, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 17, 6, 35, 976, DateTimeKind.Local).AddTicks(7110));
        }
    }
}
