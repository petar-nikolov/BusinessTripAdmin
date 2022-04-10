using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessTripAdmin.Infrastructure.Data.Migrations
{
    public partial class ChangeCountryAllowanceRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allowances_Countries_CountryId",
                table: "Allowances");

            migrationBuilder.DropIndex(
                name: "IX_Allowances_CountryId",
                table: "Allowances");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Allowances");

            migrationBuilder.AddColumn<Guid>(
                name: "AllowanceId",
                table: "Countries",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Countries_AllowanceId",
                table: "Countries",
                column: "AllowanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Allowances_AllowanceId",
                table: "Countries",
                column: "AllowanceId",
                principalTable: "Allowances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Allowances_AllowanceId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_AllowanceId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "AllowanceId",
                table: "Countries");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Allowances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Allowances_CountryId",
                table: "Allowances",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Allowances_Countries_CountryId",
                table: "Allowances",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
