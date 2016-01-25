using Rf.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rf.Web.Models
{
    public class FormulierModel
    {
        public FormulierModel()
        {
            DetailCode = new DetailCodeModel();
            Ontvanger = new PersoonModel();
            Opsteller = new PersoonModel();
            OntvangerQL = new PersoonModel();
            HoofdCode = new HoofdCodeModel();
            Soortklacht = new SoortKlachtModel();
            Voertuig = new VoertuigModel();
            QualityProcedure = new QualityProcedureModel();
            Unit = new UnitModel();
            Afdeling = new AfdelingModel();
            Rp = new RpModel();
            Klanten = new List<KlantModel>();
            Oorsprongen = new List<OorsprongModel>();
            Oorzaken = new List<OorzaakModel>();
            Cas = new List<CaModel>();
            Bestemmingen = new List<BestemmingModel>();
            Locaties = new List<LocatieModel>();
            Betrokkenen = new List<BetrokkeneModel>();
        }

        public int Id { get; set; }

        [Display(Name = "Detailcode")]
        public DetailCodeModel DetailCode { get; set; }

        [Display(Name = "RF status")]
        public EnumStatusRfModel StatusRfEnum { get; set; }

        [Display(Name = "Klanten")]
        public List<KlantModel> Klanten { get; set; }

        [Display(Name = "Oorsprongen")]
        public List<OorsprongModel> Oorsprongen { get; set; }

        [Display(Name = "Hoofdcode")]
        public HoofdCodeModel HoofdCode { get; set; }

        [Display(Name = "Beantwoord door")]
        public PersoonModel Ontvanger { get; set; }

        [Display(Name = "Beantwoord door")]
        public PersoonModel OntvangerQL { get; set; }

        [Display(Name = "Rp")]
        public RpModel Rp { get; set; }

        [Display(Name = "Oorzaken")]
        public List<OorzaakModel> Oorzaken { get; set; }
        
        [Display(Name = "CA Codes")]
        public List<CaModel> Cas { get; set; }

        [Display(Name = "Bestemmingen")]
        public List<BestemmingModel> Bestemmingen { get; set; }

        [Display(Name = "Locaties")]
        public List<LocatieModel> Locaties { get; set; }

        [Display(Name = "Betrokkenen")]
        public List<BetrokkeneModel> Betrokkenen { get; set; }

        [Display(Name = "Opsteller")]
        public PersoonModel Opsteller { get; set; }

        [Display(Name = "Detail RF")]
        public SoortKlachtModel Soortklacht { get; set; }

        [Display(Name = "Voertuig")]
        public VoertuigModel Voertuig { get; set; }

        [Display(Name = "Quality Procedure")]
        public QualityProcedureModel QualityProcedure { get; set; }

        [Display(Name = "Soort Unit")]
        public UnitModel Unit { get; set; }

        [Display(Name = "Aantal units")]
        public int AantalUnits { get; set; }

        [Display(Name = "AO nummer")]
        public string AoNummer { get; set; }

        [Display(Name = "Batch/Lot/Merk")]
        public string Batch { get; set; }

        [Display(Name = "Referentie")]
        public string Referentie { get; set; }

        [Display(Name = "Type RF")]
        public string TypeRf { get; set; }

        [Display(Name = "Claim nummer")]
        public string ClaimNummer { get; set; }

        [Display(Name = "Containernummer")]
        public string ContainerNummer { get; set; }

        [Display(Name = "Naam")]
        public string ControleReferentieOntvanger { get; set; }

        [Display(Name = "Controle referentie opsteller")]
        public string ControleReferentieOpsteller { get; set; }

        [Display(Name = "Creatiedatum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreatieDatum { get; set; }

        [Display(Name = "Afwerkingsdatum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AfwerkingsDatum { get; set; }

        [Display(Name = "Datum antwoord RF")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? OplossingsDatum { get; set; }

        [Display(Name = "Datum antwoord RF")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? OplossingsDatumQL { get; set; }

        [Display(Name = "Datum problematiek")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? VaststellingsDatum { get; set; }

        [Display(Name = "Exceptie rapporterings nummer")]
        public string ExceptieRapporteringsNummer { get; set; }

        [Display(Name = "Factuur nummer")]
        public string FactuurNummer { get; set; }

        [Display(Name = "Dossiernummers")]
        public string Dossiernummers { get; set; }

        [Display(Name = "Omschrijving gevolg")]
        public string Gevolg { get; set; }

        [Display(Name = "Eventuele toelichting")]
        public string Opmerking { get; set; }

        [Display(Name = "Kost")]
        public decimal Kost { get; set; }

        [Display(Name = "Leverancier")]
        public string Leverancier { get; set; }

        [Display(Name = "Omschrijving probleem")]
        public string Omschrijving { get; set; }

        [Display(Name = "AkmOmschrijving")]
        public string AkmOmschrijving { get; set; }

        [Display(Name = "Oorzaak achterliggend")]
        public string OorzaakAchterliggend { get; set; }

        [Display(Name = "Oorzaak omschrijving")]
        public string OorzaakOmschrijving { get; set; }

        [Display(Name = "Oplossing")]
        public string Oplossing { get; set; }

        [Display(Name = "Naam")]
        public string QualityDocumentNaam { get; set; }

        [Display(Name = "Trucknummer")]
        public string TruckNummer { get; set; }
		
	    [Display(Name = "Afdeling ontvanger")]
        public AfdelingModel Afdeling { get; set; }

        [Display(Name = "Klacht geuit door")]
        public string KlachtGeuitDoor { get; set; }

        [Required(ErrorMessage = "Gelieve de nodige velden in te vullen")]
        [Display(Name = "Klant op de hoogte van de problematiek")]
        public EnumBooleanModel CommunicatieKlantOpsteller { get; set; }

        [Display(Name = "Quality document volledig")]
        public EnumBooleanModel IsQualityDocumentVolledig { get; set; }

        [Display(Name = "Systematische controle ontvanger")]
        public EnumBooleanModel SystematischeControleOntvanger { get; set; }

        [Required(ErrorMessage = "Gelieve de nodige velden in te vullen")]
        [Display(Name = "Systematische controle opsteller")]
        public EnumBooleanModel SystematischeControleOpsteller { get; set; }

        [Display(Name = "Kost door te rekenen")]
        public EnumBooleanModel DoorrekenenKost { get; set; }

        [Display(Name = "Is nieuw quality document nodig")]
        public EnumBooleanModel IsNieuwQualityDocumentNodig { get; set; }

        [Display(Name = "Is quality document beschreven")]
        public EnumBooleanModel IsQualityDocumentBeschreven { get; set; }

        [Display(Name = "Is systematische controle volledig")]
        public EnumBooleanModel IsSystematischeControleVolledig { get; set; }

        [Display(Name = "Beveiligingsincident")]
        public EnumBooleanModel BeveiligingsIncident { get; set; }

        [Display(Name = "Klant op de hoogte van de problematiek")]
        public EnumBooleanModel CommunicatieKlantOntvanger { get; set; }

        [Display(Name = "Nieuwe controle")]
        public EnumBooleanModel NieuweControle { get; set; }

        [Display(Name = "Voorstel aanvaard")]
        public EnumBooleanModel VoorstelAanvaard { get; set; }

        [Display(Name = "Opvolging CA's?")]
        public EnumBooleanModel OpnemenCapa { get; set; }

        [Required(ErrorMessage = "Kies een Audit type")]
        [Display(Name = "Audit Type")]
        public EnumAuditTypeModel AuditTypeEnum { get; set; }

        [Required(ErrorMessage = "Kies een Type ongeval")]
        [Display(Name = "Ongeval Type")]
        public EnumOngevalTypeModel OngevalTypeEnum { get; set; }

        [Required(ErrorMessage = "Kies een Type Dossier")]
        [Display(Name = "Dossier Type")]
        public EnumDossierTypeModel DossierTypeEnum { get; set; }
    }
}