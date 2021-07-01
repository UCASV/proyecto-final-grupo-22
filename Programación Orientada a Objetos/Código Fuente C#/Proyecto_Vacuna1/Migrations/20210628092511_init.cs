using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Proyecto_Vacuna1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    disease = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Dosis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    dosis = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dosis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Index_Cabins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    index = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Index_Cabins", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionObjectives",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Institution = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionObjectives", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SideEffects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    side = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideEffects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmployees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeVaccines",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    type_Vaccine = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeVaccines", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pacients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DUI = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    adress = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    Diseaseid = table.Column<int>(type: "int", nullable: true),
                    Institutionid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacients", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pacients_Diseases_Diseaseid",
                        column: x => x.Diseaseid,
                        principalTable: "Diseases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacients_InstitutionObjectives_Institutionid",
                        column: x => x.Institutionid,
                        principalTable: "InstitutionObjectives",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    adress = table.Column<string>(type: "text", nullable: true),
                    user = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                    table.ForeignKey(
                        name: "FK_Employees_TipoEmployees_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TipoEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DateVaccines",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    Cabin1id = table.Column<int>(type: "int", nullable: true),
                    Pacientid = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Typeid = table.Column<int>(type: "int", nullable: true),
                    dosisid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateVaccines", x => x.id);
                    table.ForeignKey(
                        name: "FK_DateVaccines_Dosis_dosisid",
                        column: x => x.dosisid,
                        principalTable: "Dosis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DateVaccines_Index_Cabins_Cabin1id",
                        column: x => x.Cabin1id,
                        principalTable: "Index_Cabins",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DateVaccines_Pacients_Pacientid",
                        column: x => x.Pacientid,
                        principalTable: "Pacients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DateVaccines_TypeVaccines_Typeid",
                        column: x => x.Typeid,
                        principalTable: "TypeVaccines",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DayVaccines",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Pacientid = table.Column<int>(type: "int", nullable: true),
                    Cabinid = table.Column<int>(type: "int", nullable: true),
                    Sideid = table.Column<int>(type: "int", nullable: true),
                    TypeVaccineid = table.Column<int>(type: "int", nullable: true),
                    Dosisid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayVaccines", x => x.id);
                    table.ForeignKey(
                        name: "FK_DayVaccines_Dosis_Dosisid",
                        column: x => x.Dosisid,
                        principalTable: "Dosis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DayVaccines_Index_Cabins_Cabinid",
                        column: x => x.Cabinid,
                        principalTable: "Index_Cabins",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DayVaccines_Pacients_Pacientid",
                        column: x => x.Pacientid,
                        principalTable: "Pacients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DayVaccines_SideEffects_Sideid",
                        column: x => x.Sideid,
                        principalTable: "SideEffects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DayVaccines_TypeVaccines_TypeVaccineid",
                        column: x => x.TypeVaccineid,
                        principalTable: "TypeVaccines",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cabins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    index_cabin_1id = table.Column<int>(type: "int", nullable: true),
                    adress = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    employeeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cabins_Employees_employeeid",
                        column: x => x.employeeid,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cabins_Index_Cabins_index_cabin_1id",
                        column: x => x.index_cabin_1id,
                        principalTable: "Index_Cabins",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "id", "disease" },
                values: new object[,]
                {
                    { 1, "Hipertension arterial" },
                    { 2, "Diabetes" },
                    { 3, "Sobrepeso" },
                    { 4, "Dislipidemia" },
                    { 5, "Enfermedad Renal Cronica" },
                    { 6, "Ninguna" }
                });

            migrationBuilder.InsertData(
                table: "Dosis",
                columns: new[] { "id", "dosis" },
                values: new object[,]
                {
                    { 1, "Primera dosis" },
                    { 2, "Segunda dosis" }
                });

            migrationBuilder.InsertData(
                table: "Index_Cabins",
                columns: new[] { "id", "index" },
                values: new object[,]
                {
                    { 1, "Primera cabina" },
                    { 2, "Segunda cabina" },
                    { 3, "Tercera cabina" },
                    { 4, "Cuarta cabina" },
                    { 5, "Quinta cabina" }
                });

            migrationBuilder.InsertData(
                table: "InstitutionObjectives",
                columns: new[] { "id", "Institution" },
                values: new object[,]
                {
                    { 5, "Personal del gobierno central" },
                    { 3, "Encargados de la seguridad nacional" },
                    { 4, "Personas mayores de 18 años con enfermadades no transmisibles o alguna discapacidad" },
                    { 1, "Adultos mayores de 60 años" },
                    { 2, "Personal del sistema integrado de Salud" }
                });

            migrationBuilder.InsertData(
                table: "SideEffects",
                columns: new[] { "id", "side" },
                values: new object[,]
                {
                    { 7, "Otro" },
                    { 1, "Dolor y/o irritacion en el area de la inyeccion" },
                    { 2, "Enrojecimiento en el area de la inyeccion" },
                    { 3, "Fatiga" },
                    { 4, "Dolor de cabeza" },
                    { 5, "Fatiga" },
                    { 6, "Mialgia" },
                    { 8, "Ninguno" }
                });

            migrationBuilder.InsertData(
                table: "TipoEmployees",
                columns: new[] { "Id", "type" },
                values: new object[,]
                {
                    { 1, "Enfermero" },
                    { 2, "Doctor" },
                    { 3, "Pasante" },
                    { 4, "Policia" },
                    { 5, "Soldado" }
                });

            migrationBuilder.InsertData(
                table: "TypeVaccines",
                columns: new[] { "id", "type_Vaccine" },
                values: new object[,]
                {
                    { 2, "Sinovac" },
                    { 1, "AstraZeneca" },
                    { 3, "Phyzen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cabins_employeeid",
                table: "Cabins",
                column: "employeeid");

            migrationBuilder.CreateIndex(
                name: "IX_Cabins_index_cabin_1id",
                table: "Cabins",
                column: "index_cabin_1id");

            migrationBuilder.CreateIndex(
                name: "IX_DateVaccines_Cabin1id",
                table: "DateVaccines",
                column: "Cabin1id");

            migrationBuilder.CreateIndex(
                name: "IX_DateVaccines_dosisid",
                table: "DateVaccines",
                column: "dosisid");

            migrationBuilder.CreateIndex(
                name: "IX_DateVaccines_Pacientid",
                table: "DateVaccines",
                column: "Pacientid");

            migrationBuilder.CreateIndex(
                name: "IX_DateVaccines_Typeid",
                table: "DateVaccines",
                column: "Typeid");

            migrationBuilder.CreateIndex(
                name: "IX_DayVaccines_Cabinid",
                table: "DayVaccines",
                column: "Cabinid");

            migrationBuilder.CreateIndex(
                name: "IX_DayVaccines_Dosisid",
                table: "DayVaccines",
                column: "Dosisid");

            migrationBuilder.CreateIndex(
                name: "IX_DayVaccines_Pacientid",
                table: "DayVaccines",
                column: "Pacientid");

            migrationBuilder.CreateIndex(
                name: "IX_DayVaccines_Sideid",
                table: "DayVaccines",
                column: "Sideid");

            migrationBuilder.CreateIndex(
                name: "IX_DayVaccines_TypeVaccineid",
                table: "DayVaccines",
                column: "TypeVaccineid");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TipoId",
                table: "Employees",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_Diseaseid",
                table: "Pacients",
                column: "Diseaseid");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_Institutionid",
                table: "Pacients",
                column: "Institutionid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cabins");

            migrationBuilder.DropTable(
                name: "DateVaccines");

            migrationBuilder.DropTable(
                name: "DayVaccines");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Dosis");

            migrationBuilder.DropTable(
                name: "Index_Cabins");

            migrationBuilder.DropTable(
                name: "Pacients");

            migrationBuilder.DropTable(
                name: "SideEffects");

            migrationBuilder.DropTable(
                name: "TypeVaccines");

            migrationBuilder.DropTable(
                name: "TipoEmployees");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "InstitutionObjectives");
        }
    }
}
