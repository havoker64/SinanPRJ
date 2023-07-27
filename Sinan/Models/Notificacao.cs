using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinan.Models
{
    [Table("notificacao")]
    public class Notificacao
    {
        [Display(Name = "Código")]
        [Column("IdNotify")]
        [Key]
        public int Idnotify { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Código do cartão do SUS")]
        [Column("suscard")]
        public long suscard { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Agravo")]
        [Column("agravoNotify")]
        public string Agravo { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Data da notificação")]
        [Column("dateNotify")]
        public DateTime datenotify { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "US")]
        [Column("usNotify")]
        public string us { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Data dos primeiros sintomas")]
        [Column("dateSynptoms")]
        public DateTime datesynptoms { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Gestante")]
        [Column("pregnant")]
        public string pregnant { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Data da investigação")]
        [Column("dateInv")]
        public DateTime dateinv { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Ocupação")]
        [Column("occupation")]
        public string occupation { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display (Name = "Febre")]
        [Column("fever")]
        public bool fever { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Mialgia")]
        [Column("myalgia")]
        public bool myalgia { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Cefaleia")]
        [Column("headache")]
        public bool headache { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name ="Exantema")]
        [Column("rash")]
        public bool rash { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Vômito")]
        [Column("vomit")]
        public bool vomit { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Náuseas")]
        [Column("nausea")]
        public bool nausea { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Dor nas costas")]
        [Column("backPain")]
        public bool backPain { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Conjuntivite")]
        [Column("conjunctivitis")]
        public bool conjunctivitis { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Artrite")]
        [Column("arthritis")]
        public bool arthritis { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Artralgia intensa")]
        [Column("severeArthralgia")]
        public bool severeArthralgia { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Petéquias")]
        [Column("petechiae")]
        public bool petechiae { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Leucopenia")]
        [Column("leukopenia")]
        public bool leukopenia { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name ="PdL positiva")]
        [Column("pTieproof")]
        public bool pTieproof { get; set;}
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "PdL negativa")]
        [Column("nTieproof")]
        public bool nTieproof { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Dor retroorbital")]
        [Column("retroorbitalPain")]
        public bool retroorbitalPain { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Diabetes")]
        [Column("diabetes")]
        public bool diabetes { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Doenças hematológicas")]
        [Column("hDiseases")]
        public bool hDiseases { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Hepatopatias")]
        [Column("liverDiseases")]
        public bool liverDiseases { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Doença renal crônica")]
        [Column("ckDiseases")]
        public bool ckDisease { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Hipertensão arterial")]
        [Column("hypertension")]
        public bool hypertension { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Doença ácido péptica")]
        [Column("paDisease")]
        public bool paDisease { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Doença auto imune")]
        [Column("aiDisease")]
        public bool aiDisease { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Sorologia (IgM) Chikungunya(primeira amostra)")]
        [Column("cfSerology")]
        public bool cfSerology { get; set; }

        [Display(Name = "Coleta da primeira amostra(Chikungunya)")]
        [Column("cfsCollecting")]
        public DateTime cfsCollecting { get; set; }

        [Required]
        [Display(Name = "Status(Chikungunya)")]
        [Column("cfsStatus")]
        public string cfsStatus { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Sorologia (IgM) Chikungunya(segunda amostra)")]
        [Column("csSerology")]
        public bool csSerology { get; set; }

        [Display(Name = "Coleta da segunda amostra(Chikungunya)")]
        [Column("cssCollecting")]
        public DateTime cssCollecting { get; set; }

        [Required]
        [Display(Name = "Status(Chikungunya)")]
        [Column("cssStatus")]
        public string cssStatus { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "PRNT")]
        [Column("prnt")]
        public bool prnt { get; set; }

        [Display(Name = "Coleta da amostra(PRNT)")]
        [Column("prntCollecting")]
        public DateTime prntCollecting { get; set; }

        [Required]
        [Display(Name = "Status(PRNT)")]
        [Column("prntStatus")]
        public string prntStatus { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Sorologia (Igm) dengue")]
        [Column("dSerology")]
        public bool dSerology { get; set; }

        [Display(Name = "Coleta da amostra(Dengue)")]
        [Column("dsCollecting")]
        public DateTime dsCollecting { get; set; }

        [Required]
        [Display(Name = "Status(Dengue)")]
        [Column("dsStatus")]
        public string dsStatus { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "NS1")]
        [Column("ns1")]
        public bool ns1 { get; set; }

        [Display(Name = "Coleta da amostra(NS1")]
        [Column("ns1Collecting")]
        public DateTime ns1Collecting { get; set; }

        [Required]
        [Display(Name = "Status(NS1)")]
        [Column("ns1Status")]
        public string ns1Status { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Isolamento")]
        [Column("insulation")]
        public bool insulation { get; set; }

        [Display(Name = "Coleta da amostra(Isolamento)")]
        [Column("insCollecting")]
        public DateTime insCollecting { get; set; }

        [Required]
        [Display(Name = "Status(Isolamento)")]
        [Column("insStatus")]
        public string insStatus { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "RT-PCR")]
        [Column("rtpcr")]
        public bool rtpcr { get; set; }

        [Display(Name = "Coleta da amostra(RT-PCR)")]
        [Column("rtpcrCollecting")]
        public DateTime rtpcrCollecting { get; set; }

        [Required]
        [Display(Name = "Status(RT-PCR)")]
        [Column("rtpcrStatus")]
        public string rtpcrStatus { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Sorotipo")]
        [Column("serotype")]
        public bool serotype { get; set; }

        [Required]
        [Display(Name = "Selecione")]
        [Column("srtSelect")]
        public string srtSelect { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Dengue com sinais de alarme")]
        [Column("alarmingDengue")]
        public bool alarmingDengue { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Hipotensão postural e/ou lipotímia")]
        [Column("pHypotension")]
        public bool pHypotension { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Queda abrupta de plaquetas")]
        [Column("plateletsFall")]
        public bool plateletsFall { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Vomitos peristentes")]
        [Column("pVomiting")]
        public bool pVomiting { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Dor abdominal intensa e contínua")]
        [Column("scaPain")]
        public bool scaPain { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Letargia ou irritabilidade")]
        [Column("loIrritability")]
        public bool loIrritability { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Sangramento de mucosa/outras hemorragias")]
        [Column("moBleeding")]
        public bool moBleeding { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Aumento progressivo de hematócrito")]
        [Column("piHematocrit")]
        public bool piHematocrit { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Hepatomegalia maior ou igual a 2cm")]
        [Column("hge2cm")]
        public bool hge2cm { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Aumento de líquidos")]
        [Column("iLiquids")]
        public bool iLiquids { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Dengue grave")]
        [Column("severeDengue")]
        public bool severeDengue { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Pulso débil ou indetectável")]
        [Column("wuPulse")]
        public bool wuPulse { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "PA convergente <=20mmHg")]
        [Column("convergentbp")]
        public bool convergentbp { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Tempo de enchimento capilar")]
        [Column("crTime")]
        public bool crTime { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Acúmulo de líquidos com insuficiência repiratória")]
        [Column("afrInsuficiency")]
        public bool afrInsuficiency { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Taquicardia")]
        [Column("tachycardia")]
        public bool tachycardia { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Extremidades frias")]
        [Column("cExtremities")]
        public bool cExtremities { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Hipotensão arterial em fase tardia")]
        [Column("lsHypotension")]
        public bool lsHypotension { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Melena")]
        [Column("melena")]
        public bool melena { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Metrorragia volumosa")]
        [Column("bMetrorrhagia")]
        public bool bMetrorrhagia { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Sangramento do SNC")]
        [Column("cnsBleeding")]
        public bool cnsBleeding { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "AST/ALT>1000")]
        [Column("astalt")]
        public bool astalt { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Miocardite")]
        [Column("myocarditis")]
        public bool myocarditis { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Alteração da consciência")]
        [Column("aConciousness")]
        public bool aConciousness { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Outros órgãos")]
        [Column("aOrgans")]
        public bool aOrgans { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Outros órgãos(Especifique)")]
        [Column("organName")]
        public string organName{ get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Classificação do paciente")]
        [Column("patientClass")]
        public string patientClass { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Viajou nos ultimos 15 dias?")]
        [Column("recentTravel")]
        public bool recentTravel { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Para onde?")]
        [Column("travelPlace")]
        public string travelPlace { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Data da ida")]
        [Column("goTravel")]
        public DateTime goTravel { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Data do retorno")]
        [Column("backTravel")]
        public DateTime backTravel { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Recebeu visita de pessoas da área endêmica/epidêmica?")]
        [Column("visitor")]
        public bool visitor { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "De qual área endêmica/epidêmica?")]
        [Column("eeArea")]
        public string eeArea { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Tem conhecimento de casos semelhantes na área em que reside?")]
        [Column("areaKnlg")]
        public bool areaKnlg { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "O paciente utiliza medicamnento de uso contínuo?")]
        [Column("pMedication")]
        public bool pMedication { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Qual medicamento o paciente usa?")]
        [Column("medName")]
        public string medName { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "O paciente foi encaminhado para outro serviço de saúde?")]
        [Column("pEncaminhation")]
        public bool pEncaminhation { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Para qual serviço o paciente foi encaminhado?")]
        [Column("ePlace")]
        public string ePlace { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Qual o motivo do encaminhamento?")]
        [Column("motive")]
        public string motive { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Nome do investigador")]
        [Column("iName")]
        public string iName { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Unidade de saúde ao qual o investigador reporta")]
        [Column("iUs")]
        public string iUs { get; set; }

        [Required]
        [Display(Name = "Função do investigador")]
        [Column("iFunction")]
        public string iFunction { get; set; }
    }
}
