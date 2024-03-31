using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace duto.api.react.Server.Migrations
{
    /// <inheritdoc />
    public partial class DutoAppDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForexCandles",
                columns: table => new
                {
                    ForexCandleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    v = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vw = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    o = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    h = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    l = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    t = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    n = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForexCandles", x => x.ForexCandleID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForexCandles");
        }
    }
}
