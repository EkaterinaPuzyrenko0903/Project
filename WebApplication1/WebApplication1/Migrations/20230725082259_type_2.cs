using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class type_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatePayment",
                table: "DataInvoicesPays",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateScore",
                table: "DataInvoicesPays",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DayPay",
                table: "DataInvoicesPays",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "IdPayment",
                table: "DataInvoicesPays",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sum",
                table: "DataInvoicesPays",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SumPayment",
                table: "DataInvoicesPays",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SumScore",
                table: "DataInvoicesPays",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ViewPayment",
                table: "DataInvoicesPays",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewScore",
                table: "DataInvoicesPays",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "payCondition",
                table: "DataInvoicesPays",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePayment",
                table: "DataInvoicesPays");

            migrationBuilder.DropColumn(
                name: "DateScore",
                table: "DataInvoicesPays");

            migrationBuilder.DropColumn(
                name: "DayPay",
                table: "DataInvoicesPays");

            migrationBuilder.DropColumn(
                name: "IdPayment",
                table: "DataInvoicesPays");

            migrationBuilder.DropColumn(
                name: "Sum",
                table: "DataInvoicesPays");

            migrationBuilder.DropColumn(
                name: "SumPayment",
                table: "DataInvoicesPays");

            migrationBuilder.DropColumn(
                name: "SumScore",
                table: "DataInvoicesPays");

            migrationBuilder.DropColumn(
                name: "ViewPayment",
                table: "DataInvoicesPays");

            migrationBuilder.DropColumn(
                name: "ViewScore",
                table: "DataInvoicesPays");

            migrationBuilder.DropColumn(
                name: "payCondition",
                table: "DataInvoicesPays");
        }
    }
}
