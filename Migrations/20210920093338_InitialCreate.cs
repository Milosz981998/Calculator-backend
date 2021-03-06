using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculator.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNumber = table.Column<decimal>(type: "decimal(28,20)", precision: 28, scale: 20, nullable: false),
                    Sign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondNumber = table.Column<decimal>(type: "decimal(28,20)", precision: 28, scale: 20, nullable: false),
                    Result = table.Column<decimal>(type: "decimal(28,20)", precision: 28, scale: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "History");
        }
    }
}
