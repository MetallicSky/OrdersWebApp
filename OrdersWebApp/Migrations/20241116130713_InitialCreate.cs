using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdersWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SenderCity = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SenderAddress = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    RecipientCity = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    RecipientAddress = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    CargoWeight = table.Column<double>(type: "REAL", nullable: false),
                    CargoPickupDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
