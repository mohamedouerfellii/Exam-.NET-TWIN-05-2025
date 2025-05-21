using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TVOuerfelliMohamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chaines",
                columns: table => new
                {
                    ChaineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomChaine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomProgramme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thematique = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chaines", x => x.ChaineId);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    UtilisateurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomUtilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeeUtilisateur = table.Column<int>(type: "int", nullable: false),
                    DateExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PointsFidelite = table.Column<int>(type: "int", nullable: true),
                    PubliciteActivee = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.UtilisateurId);
                });

            migrationBuilder.CreateTable(
                name: "Programme",
                columns: table => new
                {
                    ProgrammeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomProgramme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duree = table.Column<TimeSpan>(type: "time", nullable: false),
                    Animateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChaineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programme", x => x.ProgrammeId);
                    table.ForeignKey(
                        name: "FK_Programme_Chaines_ChaineId",
                        column: x => x.ChaineId,
                        principalTable: "Chaines",
                        principalColumn: "ChaineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visionnages",
                columns: table => new
                {
                    DateVisionnage = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurFk = table.Column<int>(type: "int", nullable: false),
                    ProgrammeFk = table.Column<int>(type: "int", nullable: false),
                    Favori = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visionnages", x => new { x.UtilisateurFk, x.ProgrammeFk, x.DateVisionnage });
                    table.ForeignKey(
                        name: "FK_Visionnages_Programme_ProgrammeFk",
                        column: x => x.ProgrammeFk,
                        principalTable: "Programme",
                        principalColumn: "ProgrammeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visionnages_Utilisateurs_UtilisateurFk",
                        column: x => x.UtilisateurFk,
                        principalTable: "Utilisateurs",
                        principalColumn: "UtilisateurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programme_ChaineId",
                table: "Programme",
                column: "ChaineId");

            migrationBuilder.CreateIndex(
                name: "IX_Visionnages_ProgrammeFk",
                table: "Visionnages",
                column: "ProgrammeFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visionnages");

            migrationBuilder.DropTable(
                name: "Programme");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Chaines");
        }
    }
}
