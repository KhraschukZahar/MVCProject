using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_SportGoods.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SportViewCategory",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true),
                    categoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportViewCategory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SportGoods",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    SportViewCategoryid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportGoods", x => x.id);
                    table.ForeignKey(
                        name: "FK_SportGoods_SportViewCategory_SportViewCategoryid",
                        column: x => x.SportViewCategoryid,
                        principalTable: "SportViewCategory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SportGoods_SportViewCategoryid",
                table: "SportGoods",
                column: "SportViewCategoryid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SportGoods");

            migrationBuilder.DropTable(
                name: "SportViewCategory");
        }
    }
}
