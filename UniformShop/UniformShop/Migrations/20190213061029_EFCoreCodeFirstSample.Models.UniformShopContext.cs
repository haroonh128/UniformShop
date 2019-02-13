using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniformShop.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsUniformShopContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    custId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    custName = table.Column<string>(nullable: true),
                    userName = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    cardNumber = table.Column<long>(nullable: true),
                    notifications = table.Column<bool>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.custId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
