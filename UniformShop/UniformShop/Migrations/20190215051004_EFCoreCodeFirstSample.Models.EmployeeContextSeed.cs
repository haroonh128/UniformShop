using Microsoft.EntityFrameworkCore.Migrations;

namespace UniformShop.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsEmployeeContextSeed : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
