using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinan.Models
{
    [Table("notificacao")]
    public class Notificacao
    {
        [Display(Name = "Código")] [Column("IdNotify")] [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long? Idnotify { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Código do Paciente")] [Column("Idpacient")]
        public long? Idpacient { get; set; }
        //----------------------------------------------------------------------
        [Required] [Display(Name = "Agravo")] [Column("agravoNotify")]
        public string? Agravo { get; set; }
        //----------------------------------------------------------------------
        [Required] [Display(Name = "Data da notificação")] [Column("dateNotify")]
        public DateTime datenotify { get; set; }
        //----------------------------------------------------------------------
        [Required] [Display(Name = "US")] [Column("usNotify")]
        public string? us { get; set; }
        //----------------------------------------------------------------------
        [Required] [Display(Name = "Data dos primeiros sintomas")] [Column("dateSynptoms")]
        public DateTime datesynptoms { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Gestante")] [Column("pregnant")]
        public string? pregnant { get; set; }
        //----------------------------------------------------------------------
        [Required] [Display(Name = "Data da investigação")] [Column("dateInv")]
        public DateTime dateinv { get; set; }
        //----------------------------------------------------------------------
        [Required] [Display(Name = "Ocupação")] [Column("occupation")]
        public string? occupation { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Febre")] [Column("fever")]
        public bool fever { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Mialgia")] [Column("myalgia")]
        public bool myalgia { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Cefaleia")] [Column("headache")]
        public bool headache { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Exantema")] [Column("rash")]
        public bool rash { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Vômito")] [Column("vomit")]
        public bool vomit { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Náuseas")] [Column("nausea")]
        public bool nausea { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Dor nas costas")] [Column("backPain")]
        public bool backPain { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Conjuntivite")] [Column("conjunctivitis")]
        public bool conjunctivitis { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Artrite")] [Column("arthritis")]
        public bool arthritis { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Artralgia intensa")] [Column("severeArthralgia")]
        public bool severeArthralgia { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Petéquias")] [Column("petechiae")]
        public bool petechiae { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Leucopenia")] [Column("leukopenia")]
        public bool leukopenia { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "PdL positiva")] [Column("pTieproof")]
        public bool pTieproof { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "PdL negativa")] [Column("nTieproof")]
        public bool nTieproof { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Dor retroorbital")] [Column("retroorbitalPain")]
        public bool retroorbitalPain { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Diabetes")] [Column("diabetes")]
        public bool diabetes { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Doenças hematológicas")] [Column("hDiseases")]
        public bool hDiseases { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Hepatopatias")] [Column("liverDiseases")]
        public bool liverDiseases { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Doença renal crônica")]
        [Column("ckDiseases")]
        public bool ckDisease { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Hipertensão arterial")] [Column("hypertension")]
        public bool hypertension { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Doença ácido péptica")] [Column("paDisease")]
        public bool paDisease { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Doença auto imune")] [Column("aiDisease")]
        public bool aiDisease { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "1° Coleta de amostra(Chikungunya)")] [Column("cfsCollecting")]
        public DateTime? cfsCollecting { get; set; }

        [Display(Name = "Status(Chikungunya)")] [Column("cfsStatus")]
        public string? cfsStatus { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "2° Coleta de amostra(Chikungunya)")] [Column("cssCollecting")]
        public DateTime? cssCollecting { get; set; }

        [Display(Name = "Status(Chikungunya)")] [Column("cssStatus")]
        public string? cssStatus { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Coleta da amostra(PRNT)")] [Column("prntCollecting")]
        public DateTime? prntCollecting { get; set; }

        [Display(Name = "Status(PRNT)")] [Column("prntStatus")]
        public string? prntStatus { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Coleta da amostra(Dengue)")] [Column("dsCollecting")]
        public DateTime? dsCollecting { get; set; }

        [Display(Name = "Status(Dengue)")] [Column("dsStatus")]
        public string? dsStatus { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Coleta da amostra(NS1)")] [Column("ns1Collecting")]
        public DateTime? ns1Collecting { get; set; }

        [Display(Name = "Status(NS1)")] [Column("ns1Status")]
        public string? ns1Status { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Coleta da amostra(Isolamento)")] [Column("insCollecting")]
        public DateTime? insCollecting { get; set; }

        [Display(Name = "Status(Isolamento)")] [Column("insStatus")]
        public string? insStatus { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Coleta da amostra(RT-PCR)")] [Column("rtpcrCollecting")]
        public DateTime? rtpcrCollecting { get; set; }

        [Display(Name = "Status(RT-PCR)")] [Column("rtpcrStatus")]
        public string? rtpcrStatus { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Sorotipo")] [Column("serotype")]
        public string? serotype { get; set; }

        [Display(Name = "Selecione o sorotipo")] [Column("srtSelect")]
        public string? srtSelect { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Hipotensão postural e/ou lipotímia")] [Column("pHypotension")]
        public bool pHypotension { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Queda abrupta de plaquetas")] [Column("plateletsFall")]
        public bool plateletsFall { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Vomitos peristentes")] [Column("pVomiting")]
        public bool pVomiting { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Dor abdominal intensa e contínua")] [Column("scaPain")]
        public bool scaPain { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Letargia ou irritabilidade")] [Column("loIrritability")]
        public bool loIrritability { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Sangramento de mucosa/outras hemorragias")] [Column("moBleeding")]
        public bool moBleeding { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Aumento progressivo de hematócrito")] [Column("piHematocrit")]
        public bool piHematocrit { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Data do inicio dos sinais de alarme")] [Column("alarmingDate")]
        public DateTime? alarmingDate { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Hepatomegalia >= a 2cm")] [Column("hge2cm")]
        public bool hge2cm { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Aumento de líquidos")] [Column("iLiquids")]
        public bool iLiquids { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Pulso débil ou indetectável")] [Column("wuPulse")]
        public bool wuPulse { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "PA convergente <=20mmHg")] [Column("convergentbp")]
        public bool convergentbp { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Tempo de enchimento capilar")] [Column("crTime")]
        public bool crTime { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Acúmulo de líquidos com falta de ar")] [Column("afrInsuficiency")]
        public bool afrInsuficiency { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Taquicardia")] [Column("tachycardia")]
        public bool tachycardia { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Extremidades frias")] [Column("cExtremities")]
        public bool cExtremities { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Hipotensão arterial em fase tardia")] [Column("lsHypotension")]
        public bool lsHypotension { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Hematêmese")] [Column("hematemesis")]
        public bool hematemesis { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Melena")] [Column("melena")]
        public bool melena { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Metrorragia volumosa")] [Column("bMetrorrhagia")]
        public bool bMetrorrhagia { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Sangramento do SNC")] [Column("cnsBleeding")]
        public bool cnsBleeding { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "AST/ALT>1000")] [Column("astalt")]
        public bool astalt { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Miocardite")] [Column("myocarditis")]
        public bool myocarditis { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Alteração da consciência")] [Column("aConciousness")]
        public bool aConciousness { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Outros órgãos")] [Column("aOrgans")]
        public bool aOrgans { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Outros órgãos(Especifique)")] [Column("organName")]
        public string? organName { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Data do início dos sintomas graves")] [Column("sinDateinit")]
        public DateTime? sinDateinit { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Classificação do paciente")] [Column("patientClass")]
        public string? patientClass { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Viajou nos ultimos 15 dias?")] [Column("recentTravel")]
        public bool recentTravel { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Destino da viagem")] [Column("travelPlace")]
        public string? travelPlace { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Data da ida")] [Column("goTravel")]
        public DateTime? goTravel { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Data do retorno")] [Column("backTravel")]
        public DateTime? backTravel { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Recebeu visitante da área endêmica/epidêmica?")] [Column("visitor")]
        public bool visitor { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "De qual área endêmica/epidêmica?")] [Column("eeArea")]
        public string? eeArea { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Houveram casos parecidos na área de residência?")] [Column("areaKnlg")]
        public bool areaKnlg { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "O paciente utiliza medicamento de uso contínuo?")] [Column("pMedication")]
        public bool pMedication { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Qual medicamento o paciente usa?")] [Column("medName")]
        public string? medName { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Paciente encaminhado para outro serviço de saúde?")] [Column("pEncaminhation")]
        public bool pEncaminhation { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Nome do outro serviço")] [Column("ePlace")]
        public string? ePlace { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Motivo do encaminhamento")] [Column("motive")]
        public string? motive { get; set; }
        //----------------------------------------------------------------------
        [Required] [Display(Name = "Nome do investigador")] [Column("iName")]
        public string? iName { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Unidade de saúde do investigador")] [Column("iUs")]
        public string? iUs { get; set; }
        //----------------------------------------------------------------------
        [Required] [Display(Name = "Função do investigador")] [Column("iFunction")]
        public string? iFunction { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Ocorreu Hospitalização")] [Column("hospitalization")]
        public bool hospitalization { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Data da internação")] [Column("hospDate")]
        public DateTime? hospDate { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "UF do Hospital")] [Column("hospUF")]
        public string? hospUF { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Município do hospital")] [Column("hospMun")]
        public string? hospMun { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Nome do Hospital")] [Column("hospName")]
        public string? hospName { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Caso autóctone do município?")] [Column("caseMun")]
        public string? caseMun { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "UF do caso")] [Column("munUf")]
        public string? munUf { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Município onde ocorreu")] [Column("munCon")]
        public string? munCon { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Bairro onde ocorreu o caso")] [Column("neighborhood")]
        public string? neighborhood { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Classificação do caso")] [Column("conClass")]
        public string? conClass { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Critério de Nução/Descarte")] [Column("criterion")]
        public string? criterion { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Evolução do caso")] [Column("caseEvo")]
        public string? caseEvo { get; set; }
        //----------------------------------------------------------------------
        [Required] [Display(Name = "Data do Encerramento")] [Column("closingDate")]
        public DateTime closingDate { get; set; }
    }
}
