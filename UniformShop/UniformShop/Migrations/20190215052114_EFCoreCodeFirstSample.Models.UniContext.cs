﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace UniformShop.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsUniContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variations_Items_itemId",
                table: "Variations");

            migrationBuilder.DropIndex(
                name: "IX_Variations_itemId",
                table: "Variations");

            migrationBuilder.DropColumn(
                name: "itemId",
                table: "Variations");

            migrationBuilder.AddColumn<string>(
                name: "varDescription",
                table: "Variations",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Variations_Items_varId",
                table: "Variations",
                column: "varId",
                principalTable: "Items",
                principalColumn: "itemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variations_Items_varId",
                table: "Variations");

            migrationBuilder.DropColumn(
                name: "varDescription",
                table: "Variations");

            migrationBuilder.AddColumn<long>(
                name: "itemId",
                table: "Variations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Variations_itemId",
                table: "Variations",
                column: "itemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Variations_Items_itemId",
                table: "Variations",
                column: "itemId",
                principalTable: "Items",
                principalColumn: "itemId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
