using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMarketNovi.Migrations
{
    public partial class nazivi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    KorisnickoIme = table.Column<string>(nullable: false),
                    Lozinka = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    AdresaIsporuke = table.Column<string>(nullable: true),
                    SigurnosnoPitanje = table.Column<string>(nullable: true),
                    Odgovor = table.Column<string>(nullable: true),
                    BrojBodova = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VrstaPlacanja = table.Column<string>(nullable: false),
                    Isporuceno = table.Column<bool>(nullable: false),
                    KlijentId = table.Column<int>(nullable: false),
                    Klijent = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Narudzba_Osoba_Klijent",
                        column: x => x.Klijent,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    ProizvodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: false),
                    Proizvodjac = table.Column<string>(nullable: true),
                    KolicinaNaStanju = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    NaAkciji = table.Column<bool>(nullable: false),
                    NovaCijena = table.Column<double>(nullable: false),
                    KolicinaUPakovanju = table.Column<double>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    NarudzbaId = table.Column<int>(nullable: true),
                    SastavProizvoda = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.ProizvodID);
                    table.ForeignKey(
                        name: "FK_Proizvod_Narudzba_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkaNarudzbe",
                columns: table => new
                {
                    StavkaNarudzbeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Kolicina = table.Column<int>(nullable: false),
                    NarudzbaId = table.Column<int>(nullable: false),
                    ProizvodId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaNarudzbe", x => x.StavkaNarudzbeId);
                    table.ForeignKey(
                        name: "FK_StavkaNarudzbe_Narudzba_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkaNarudzbe_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_Klijent",
                table: "Narudzba",
                column: "Klijent");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_NarudzbaId",
                table: "Proizvod",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaNarudzbe_NarudzbaId",
                table: "StavkaNarudzbe",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaNarudzbe_ProizvodId",
                table: "StavkaNarudzbe",
                column: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StavkaNarudzbe");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Osoba");
        }
    }
}
