using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class CreateEntityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnställdBefattningars",
                columns: table => new
                {
                    Anställdid = table.Column<int>(type: "int", nullable: false),
                    Befattningid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnställdBefattningars", x => new { x.Anställdid, x.Befattningid });
                });

            migrationBuilder.CreateTable(
                name: "Anställds",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FörNamn = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    EfterNamn = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Avdelningid = table.Column<int>(type: "int", nullable: false),
                    Lön = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fackförening = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anställds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Avdelnings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Företagid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avdelnings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Beffatnings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beffatnings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Företags",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    OrgNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Företags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AnställdAnställdBefattningar",
                columns: table => new
                {
                    Anställdsid = table.Column<int>(type: "int", nullable: false),
                    AnställdBefattningarsAnställdid = table.Column<int>(type: "int", nullable: false),
                    AnställdBefattningarsBefattningid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnställdAnställdBefattningar", x => new { x.Anställdsid, x.AnställdBefattningarsAnställdid, x.AnställdBefattningarsBefattningid });
                    table.ForeignKey(
                        name: "FK_AnställdAnställdBefattningar_AnställdBefattningars_AnställdBefattningarsAnställdid_AnställdBefattningarsBefattningid",
                        columns: x => new { x.AnställdBefattningarsAnställdid, x.AnställdBefattningarsBefattningid },
                        principalTable: "AnställdBefattningars",
                        principalColumns: new[] { "Anställdid", "Befattningid" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnställdAnställdBefattningar_Anställds_Anställdsid",
                        column: x => x.Anställdsid,
                        principalTable: "Anställds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnställdAvdelning",
                columns: table => new
                {
                    Anställdsid = table.Column<int>(type: "int", nullable: false),
                    Avdelningsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnställdAvdelning", x => new { x.Anställdsid, x.Avdelningsid });
                    table.ForeignKey(
                        name: "FK_AnställdAvdelning_Anställds_Anställdsid",
                        column: x => x.Anställdsid,
                        principalTable: "Anställds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnställdAvdelning_Avdelnings_Avdelningsid",
                        column: x => x.Avdelningsid,
                        principalTable: "Avdelnings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnställdBefattningarBeffatning",
                columns: table => new
                {
                    Beffatningsid = table.Column<int>(type: "int", nullable: false),
                    AnställdBefattningarsAnställdid = table.Column<int>(type: "int", nullable: false),
                    AnställdBefattningarsBefattningid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnställdBefattningarBeffatning", x => new { x.Beffatningsid, x.AnställdBefattningarsAnställdid, x.AnställdBefattningarsBefattningid });
                    table.ForeignKey(
                        name: "FK_AnställdBefattningarBeffatning_AnställdBefattningars_AnställdBefattningarsAnställdid_AnställdBefattningarsBefattningid",
                        columns: x => new { x.AnställdBefattningarsAnställdid, x.AnställdBefattningarsBefattningid },
                        principalTable: "AnställdBefattningars",
                        principalColumns: new[] { "Anställdid", "Befattningid" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnställdBefattningarBeffatning_Beffatnings_Beffatningsid",
                        column: x => x.Beffatningsid,
                        principalTable: "Beffatnings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvdelningFöretag",
                columns: table => new
                {
                    Avdelningarid = table.Column<int>(type: "int", nullable: false),
                    Företagsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvdelningFöretag", x => new { x.Avdelningarid, x.Företagsid });
                    table.ForeignKey(
                        name: "FK_AvdelningFöretag_Avdelnings_Avdelningarid",
                        column: x => x.Avdelningarid,
                        principalTable: "Avdelnings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvdelningFöretag_Företags_Företagsid",
                        column: x => x.Företagsid,
                        principalTable: "Företags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnställdAnställdBefattningar_AnställdBefattningarsAnställdid_AnställdBefattningarsBefattningid",
                table: "AnställdAnställdBefattningar",
                columns: new[] { "AnställdBefattningarsAnställdid", "AnställdBefattningarsBefattningid" });

            migrationBuilder.CreateIndex(
                name: "IX_AnställdAvdelning_Avdelningsid",
                table: "AnställdAvdelning",
                column: "Avdelningsid");

            migrationBuilder.CreateIndex(
                name: "IX_AnställdBefattningarBeffatning_AnställdBefattningarsAnställdid_AnställdBefattningarsBefattningid",
                table: "AnställdBefattningarBeffatning",
                columns: new[] { "AnställdBefattningarsAnställdid", "AnställdBefattningarsBefattningid" });

            migrationBuilder.CreateIndex(
                name: "IX_AvdelningFöretag_Företagsid",
                table: "AvdelningFöretag",
                column: "Företagsid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnställdAnställdBefattningar");

            migrationBuilder.DropTable(
                name: "AnställdAvdelning");

            migrationBuilder.DropTable(
                name: "AnställdBefattningarBeffatning");

            migrationBuilder.DropTable(
                name: "AvdelningFöretag");

            migrationBuilder.DropTable(
                name: "Anställds");

            migrationBuilder.DropTable(
                name: "AnställdBefattningars");

            migrationBuilder.DropTable(
                name: "Beffatnings");

            migrationBuilder.DropTable(
                name: "Avdelnings");

            migrationBuilder.DropTable(
                name: "Företags");
        }
    }
}
