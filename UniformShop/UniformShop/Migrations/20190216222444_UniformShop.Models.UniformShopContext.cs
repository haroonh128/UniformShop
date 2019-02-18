using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniformShop.Migrations
{
    public partial class UniformShopModelsUniformShopContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

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

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    sizeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sizeName = table.Column<string>(nullable: true),
                    sizeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.sizeId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    subCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    subCategoryName = table.Column<string>(nullable: true),
                    categoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.subCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    itemId = table.Column<long>(nullable: false),
                    custId = table.Column<long>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    createdBy = table.Column<string>(nullable: true),
                    createdDate = table.Column<string>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true),
                    modifiedDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_custId",
                        column: x => x.custId,
                        principalTable: "Customers",
                        principalColumn: "custId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orderDetails",
                columns: table => new
                {
                    ordDetailId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    orderId = table.Column<long>(nullable: true),
                    orderStatus = table.Column<bool>(nullable: false),
                    quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderDetails", x => x.ordDetailId);
                    table.ForeignKey(
                        name: "FK_orderDetails_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    tranId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tranDate = table.Column<string>(nullable: true),
                    totalAmt = table.Column<int>(nullable: false),
                    orderId = table.Column<long>(nullable: true),
                    profit = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    paymentMethod = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.tranId);
                    table.ForeignKey(
                        name: "FK_Transactions_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    itemId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    itemName = table.Column<string>(nullable: true),
                    imgId = table.Column<long>(nullable: true),
                    categoryId = table.Column<long>(nullable: false),
                    sizeId = table.Column<long>(nullable: true),
                    colorId = table.Column<long>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.itemId);
                    table.ForeignKey(
                        name: "FK_Items_Sizes_sizeId",
                        column: x => x.sizeId,
                        principalTable: "Sizes",
                        principalColumn: "sizeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Variations",
                columns: table => new
                {
                    varId = table.Column<long>(nullable: false),
                    varDescription = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variations", x => x.varId);
                    table.ForeignKey(
                        name: "FK_Variations_Items_varId",
                        column: x => x.varId,
                        principalTable: "Items",
                        principalColumn: "itemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    colorId = table.Column<long>(nullable: false),
                    colorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.colorId);
                    table.ForeignKey(
                        name: "FK_Colors_Variations_colorId",
                        column: x => x.colorId,
                        principalTable: "Variations",
                        principalColumn: "varId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    imgId = table.Column<long>(nullable: false),
                    imgName = table.Column<string>(nullable: true),
                    imgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.imgId);
                    table.ForeignKey(
                        name: "FK_Images_Variations_imgId",
                        column: x => x.imgId,
                        principalTable: "Variations",
                        principalColumn: "varId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_colorId",
                table: "Items",
                column: "colorId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_imgId",
                table: "Items",
                column: "imgId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_sizeId",
                table: "Items",
                column: "sizeId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_orderId",
                table: "orderDetails",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_custId",
                table: "Orders",
                column: "custId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_categoryId",
                table: "SubCategories",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_orderId",
                table: "Transactions",
                column: "orderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Colors_colorId",
                table: "Items",
                column: "colorId",
                principalTable: "Colors",
                principalColumn: "colorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Images_imgId",
                table: "Items",
                column: "imgId",
                principalTable: "Images",
                principalColumn: "imgId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Variations_colorId",
                table: "Colors");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Variations_imgId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "orderDetails");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Variations");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
