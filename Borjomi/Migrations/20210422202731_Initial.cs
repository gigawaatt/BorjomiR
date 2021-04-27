using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Borjomi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    middle_name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    birth_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    bdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    edate = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
