using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DGII.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contribuyentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    rncCedula = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribuyentes", x => new { x.Id, x.rncCedula });
                    table.ForeignKey(
                        name: "FK_Contribuyentes_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comprobantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Itbis18 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ncf = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    ContribuyenteId = table.Column<int>(type: "int", nullable: false),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    rncCedula = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comprobantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comprobantes_Contribuyentes_ContribuyenteId_rncCedula",
                        columns: x => new { x.ContribuyenteId, x.rncCedula },
                        principalTable: "Contribuyentes",
                        principalColumns: new[] { "Id", "rncCedula" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Activo" },
                    { 2, "Inactivo" }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "PERSONA FISICA" },
                    { 2, "PERSONA JURIDICA" }
                });

            migrationBuilder.InsertData(
                table: "Contribuyentes",
                columns: new[] { "Id", "rncCedula", "EstadoId", "Nombre", "TipoId" },
                values: new object[,]
                {
                    { 1, "98754321012", 1, "JUAN PEREZ", 1 },
                    { 2, "123456789", 2, "FARMACIA TU SALUD", 2 },
                    { 3, "123876879", 1, "Jose Perez", 1 },
                    { 4, "89239473", 2, "COLMADO FULANITO", 2 },
                    { 5, "1245484796", 1, "EDDY GRULLON", 1 },
                    { 6, "56677867866", 2, "DGII", 2 },
                    { 7, "5567733467", 1, "CARLOS MENA", 1 },
                    { 8, "5611675673", 2, "MARIANO TERRERO", 2 },
                    { 9, "3111245454", 1, "EDWARD CRUZ", 1 },
                    { 10, "4442888566", 2, "LA SIRENA", 2 },
                    { 11, "45345345236", 1, "DIANA RIVAS", 1 },
                    { 12, "66565657443", 2, "SALON JOSEFINA", 2 }
                });

            migrationBuilder.InsertData(
                table: "Comprobantes",
                columns: new[] { "Id", "ContribuyenteId", "Itbis18", "Monto", "Ncf", "rncCedula" },
                values: new object[,]
                {
                    { 1, 1, 36m, 200m, "E310000000001", "98754321012" },
                    { 2, 1, 180m, 1000m, "E310000000002", "98754321012" },
                    { 3, 1, 36m, 200m, "E310000000003", "98754321012" },
                    { 4, 1, 180m, 1000m, "E310000000004", "98754321012" },
                    { 5, 1, 36m, 200m, "E310000000005", "98754321012" },
                    { 6, 1, 180m, 1000m, "E310000000006", "98754321012" },
                    { 7, 1, 36m, 200m, "E310000000007", "98754321012" },
                    { 8, 2, 180m, 1000m, "E310000000008", "123456789" },
                    { 9, 2, 36m, 200m, "E310000000009", "123456789" },
                    { 10, 2, 180m, 1000m, "E310000000010", "123456789" },
                    { 11, 2, 36m, 200m, "E310000000011", "123456789" },
                    { 12, 2, 180m, 1000m, "E310000000012", "123456789" },
                    { 13, 3, 180m, 1000m, "E310000000013", "123876879" },
                    { 14, 3, 36m, 200m, "E310000000014", "123876879" },
                    { 15, 3, 180m, 1000m, "E310000000015", "123876879" },
                    { 16, 3, 36m, 200m, "E310000000016", "123876879" },
                    { 17, 3, 180m, 1000m, "E310000000017", "123876879" },
                    { 18, 3, 36m, 200m, "E310000000018", "123876879" },
                    { 19, 3, 180m, 1000m, "E310000000019", "123876879" },
                    { 20, 3, 36m, 200m, "E310000000020", "123876879" },
                    { 21, 3, 180m, 1000m, "E310000000021", "123876879" },
                    { 22, 3, 36m, 200m, "E310000000022", "123876879" },
                    { 23, 3, 180m, 1000m, "E310000000023", "123876879" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_ContribuyenteId_rncCedula",
                table: "Comprobantes",
                columns: new[] { "ContribuyenteId", "rncCedula" });

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_Ncf",
                table: "Comprobantes",
                column: "Ncf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_EstadoId",
                table: "Contribuyentes",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_TipoId",
                table: "Contribuyentes",
                column: "TipoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comprobantes");

            migrationBuilder.DropTable(
                name: "Contribuyentes");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Tipos");
        }
    }
}
