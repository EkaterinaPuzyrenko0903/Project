using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class payments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataInvoicesPays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    IdClient = table.Column<int>(type: "INTEGER", nullable: false),
                    IdScore = table.Column<int>(type: "INTEGER", nullable: false),
                    DateScore = table.Column<DateTime>(type: "datetime", nullable: false),
                    ViewScore = table.Column<string>(type: "TEXT", nullable: true),
                    payCondition = table.Column<int>(type: "INTEGER", nullable: false),
                    IdPayment = table.Column<int>(type: "INTEGER", nullable: false),
                    DatePayment = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ViewPayment = table.Column<string>(type: "TEXT", nullable: true),
                    DayPay = table.Column<int>(type: "INTEGER", nullable: false),
                    SumScore = table.Column<double>(type: "REAL", nullable: false),
                    SumPayment = table.Column<double>(type: "REAL", nullable: false),
                    Sum = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataInvoicesPays", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataInvoicesPays");
        }
    }
}
