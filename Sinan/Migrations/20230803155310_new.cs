using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinan.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "notificacao",
                columns: table => new
                {
                    IdNotify = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    suscard = table.Column<long>(type: "bigint", nullable: false),
                    agravoNotify = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateNotify = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    usNotify = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateSynptoms = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    pregnant = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateInv = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    occupation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fever = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    myalgia = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    headache = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    rash = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    vomit = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    nausea = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    backPain = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    conjunctivitis = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    arthritis = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    severeArthralgia = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    petechiae = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    leukopenia = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pTieproof = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    nTieproof = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    retroorbitalPain = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    diabetes = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    hDiseases = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    liverDiseases = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ckDiseases = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    hypertension = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    paDisease = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    aiDisease = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    cfSerology = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    cfsCollecting = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    cfsStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    csSerology = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    cssCollecting = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    cssStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prnt = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    prntCollecting = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    prntStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dSerology = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    dsCollecting = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    dsStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ns1 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ns1Collecting = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ns1Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    insulation = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    insCollecting = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    insStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rtpcr = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    rtpcrCollecting = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    rtpcrStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    serotype = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    srtSelect = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    alarmingDengue = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pHypotension = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    plateletsFall = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pVomiting = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    scaPain = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    loIrritability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    moBleeding = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    piHematocrit = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    hge2cm = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    iLiquids = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    severeDengue = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    wuPulse = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    convergentbp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    crTime = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    afrInsuficiency = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    tachycardia = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    cExtremities = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    lsHypotension = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    hematemesis = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    melena = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    bMetrorrhagia = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    cnsBleeding = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    astalt = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    myocarditis = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    aConciousness = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    aOrgans = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    organName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sinDateinit = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    patientClass = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    recentTravel = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    travelPlace = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    goTravel = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    backTravel = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    visitor = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    eeArea = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    areaKnlg = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pMedication = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    medName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pEncaminhation = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ePlace = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    motive = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iUs = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iFunction = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hospitalization = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    hospDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    hospUF = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hospMun = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hospName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    caseMun = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    munUf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    munCon = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    neighborhood = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    conClass = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    criterion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    caseEvo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    closingDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notificacao", x => x.IdNotify);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    birthdate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    schooling = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    suscard = table.Column<long>(type: "bigint", nullable: false),
                    momname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ancestry = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    height = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    weight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    uf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    municipality = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    neighborhood = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    cep = table.Column<long>(type: "bigint", nullable: false),
                    zone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paciente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "notificacao");

            migrationBuilder.DropTable(
                name: "paciente");
        }
    }
}
