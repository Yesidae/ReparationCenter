using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReparationCenter.BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyReparations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerPhone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechnicalComents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RepairStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RepairValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFinished = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyReparations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyReparations");
        }
    }
}
