using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizza.Migrations
{
    public partial class SliderTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subheading = table.Column<string>(maxLength: 25, nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Desc = table.Column<string>(maxLength: 225, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    RedirectUrlOrder = table.Column<string>(maxLength: 250, nullable: true),
                    RedirectUrlMenu = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
