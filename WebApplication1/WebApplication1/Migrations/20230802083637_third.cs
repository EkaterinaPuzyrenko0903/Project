using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnpaidBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    kodBranch = table.Column<int>(type: "INTEGER", nullable: false),
                    kodClient = table.Column<int>(type: "INTEGER", nullable: false),
                    numberDoc = table.Column<int>(type: "INTEGER", nullable: false),
                    View = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    payCondition = table.Column<int>(type: "INTEGER", nullable: false),
                    sum = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnpaidBills", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnpaidBills");
        }
    }
}
