using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aeronave.Infraestructure.EF.Migrations
{
    public partial class InitialStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsignacionAeronave",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAsignacionAeronave = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    IdAeronave = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    IdVuelo = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    NroAsientosAeronave = table.Column<int>(type: "int", nullable: false),
                    EstadoAsignacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionAeronave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControlAeronave",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAeronave = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdControlAeronave = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CapacidadCarga = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    CapTanqueCombustible = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    AereopuertoEstacionamiento = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EstadoFuncionalAeronave = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AsientosAsignados = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlAeronave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aeronave",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAeronave = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    CodAeronave = table.Column<int>(type: "int", nullable: false),
                    IdAeropuerto = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    IdControlAeronave = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAsignacionAeronave = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalNroAsientos = table.Column<int>(type: "int", nullable: false),
                    EstadoDisponibilidad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)

                    // ControlAeronaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                }

                /*,
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aeronave_ControlAeronave_ControlAeronaveId",
                        column: x => x.ControlAeronaveId,
                        principalTable: "ControlAeronave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                }
                */
                ) ;
                
/*
            migrationBuilder.CreateIndex(
                name: "IX_Aeronave_ControlAeronaveId",
                table: "Aeronave",
                column: "ControlAeronaveId");
*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeronave");

            migrationBuilder.DropTable(
                name: "AsignacionAeronave");

            migrationBuilder.DropTable(
                name: "ControlAeronave");
        }
    }
}
