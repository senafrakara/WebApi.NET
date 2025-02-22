using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ProductStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleDomestic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionDomestic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceDiscountedDomestic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceDiscounted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsElonkyFeatured = table.Column<bool>(type: "bit", nullable: false),
                    HasVideo = table.Column<bool>(type: "bit", nullable: false),
                    HasPersonalization = table.Column<bool>(type: "bit", nullable: false),
                    IsTaxable = table.Column<bool>(type: "bit", nullable: false),
                    WhenMade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhoMade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalizationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDigital = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
