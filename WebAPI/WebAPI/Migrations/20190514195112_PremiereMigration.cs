using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class PremiereMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    UtilisateurId = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Prénom = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.UtilisateurId);
                });

            migrationBuilder.CreateTable(
                name: "Bateau",
                columns: table => new
                {
                    BateauId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: false),
                    Longueur = table.Column<float>(nullable: false),
                    Largeur = table.Column<float>(nullable: false),
                    Poids = table.Column<float>(nullable: false),
                    AnnéeFabrication = table.Column<int>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bateau", x => x.BateauId);
                    table.ForeignKey(
                        name: "FK_Bateau_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "UtilisateurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position_bateau",
                columns: table => new
                {
                    Position_BateauId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Et = table.Column<float>(nullable: false),
                    Ap = table.Column<float>(nullable: false),
                    PLt = table.Column<float>(nullable: false),
                    PLg = table.Column<float>(nullable: false),
                    PH = table.Column<float>(nullable: false),
                    PHm = table.Column<float>(nullable: false),
                    PS = table.Column<float>(nullable: false),
                    PSr = table.Column<float>(nullable: false),
                    PC = table.Column<float>(nullable: false),
                    WAs = table.Column<float>(nullable: false),
                    WAa = table.Column<float>(nullable: false),
                    WTa = table.Column<float>(nullable: false),
                    WTd = table.Column<float>(nullable: false),
                    WTD2 = table.Column<float>(nullable: false),
                    WTs = table.Column<float>(nullable: false),
                    BS = table.Column<float>(nullable: false),
                    v = table.Column<float>(nullable: false),
                    s = table.Column<float>(nullable: false),
                    BateauId = table.Column<int>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false),
                    e = table.Column<float>(nullable: false),
                    t = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position_bateau", x => x.Position_BateauId);
                    table.ForeignKey(
                        name: "FK_Position_bateau_Bateau_BateauId",
                        column: x => x.BateauId,
                        principalTable: "Bateau",
                        principalColumn: "BateauId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Position_bateau_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "UtilisateurId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bateau_UtilisateurId",
                table: "Bateau",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_bateau_BateauId",
                table: "Position_bateau",
                column: "BateauId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_bateau_UtilisateurId",
                table: "Position_bateau",
                column: "UtilisateurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Position_bateau");

            migrationBuilder.DropTable(
                name: "Bateau");

            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
