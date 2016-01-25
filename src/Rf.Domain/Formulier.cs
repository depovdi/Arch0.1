using System;
using System.Collections.Generic;

namespace Rf.Domain
{
    public class Formulier
    {
        public Formulier()
        {
            Betrokkenen = new List<Betrokkene>();
            Klanten = new List<Klant>();
            Oorsprongen = new List<Oorsprong>();
            Bestemmingen = new List<Bestemming>();
            Locaties = new List<Locatie>();
            Soorten = new List<Soort>();
            Oorzaken = new List<Oorzaak>();
            Cas = new List<Ca>();
        }

        public int Id { get; set; }
        public DateTime? AfwerkingsDatum { get; set; }
        public DateTime? OplossingsDatum { get; set; }
        public DateTime? CreatieDatum { get; set; }
        public DateTime? OplossingsDatumQL { get; set; }
        public DateTime? VaststellingsDatum { get; set; }
        public string Omschrijving { get; set; }
        public string AkmOmschrijving { get; set; }
        public string Oplossing { get; set; }
        public string Referentie { get; set; }
        public string TypeRf { get; set; }
        public string ClaimNummer { get; set; }
        public decimal Kost { get; set; }
        public string ContainerNummer { get; set; }
        public string TruckNummer { get; set; }
        public int AantalUnits { get; set; }
        public string Batch { get; set; }
        public string ControleReferentieOpsteller { get; set; }
        public string ControleReferentieOntvanger { get; set; }
        public string ExceptieRapporteringsNummer { get; set; }
        public string QualityDocumentNaam { get; set; }
        public string AoNummer { get; set; }
        public string Gevolg { get; set; }
        public string OorzaakOmschrijving { get; set; }
        public string OorzaakAchterliggend { get; set; }
        public string FactuurNummer { get; set; }
        public string Dossiernummers { get; set; }
        public string Opmerking { get; set; }
        public string Leverancier { get; set; }
        public string KlachtGeuitDoor { get; set; }

        public EnumBoolean CommunicatieKlantOpsteller { get; set; }
        public EnumBoolean CommunicatieKlantOntvanger { get; set; }
        public EnumBoolean BeveiligingsIncident { get; set; }
        public EnumBoolean SystematischeControleOpsteller { get; set; }
        public EnumBoolean SystematischeControleOntvanger { get; set; }
        public EnumBoolean IsSystematischeControleVolledig { get; set; }
        public EnumBoolean NieuweControle { get; set; }
        public EnumBoolean IsQualityDocumentBeschreven { get; set; }
        public EnumBoolean IsQualityDocumentVolledig { get; set; }
        public EnumBoolean IsNieuwQualityDocumentNodig { get; set; }
        public EnumBoolean DoorrekenenKost { get; set; }
        public EnumBoolean VoorstelAanvaard { get; set; }
        public EnumBoolean OpnemenCapa { get; set; }

        public EnumAuditType AuditTypeEnum { get; set; }
        public EnumOngevalType OngevalTypeEnum { get; set; }
        public EnumDossierType DossierTypeEnum { get; set; }
        public EnumStatusRf StatusRfEnum { get; set; }

        public virtual Voertuig Voertuig { get; set; }
        public virtual SoortKlacht Soortklacht { get; set; }
        public virtual Persoon Opsteller { get; set; }
        public virtual Persoon Ontvanger { get; set; }
        public virtual Persoon OntvangerQL { get; set; }
        public virtual DetailCode DetailCode { get; set; }
        public virtual Rp Rp { get; set; }
        public virtual QualityProcedure QualityProcedure { get; set; }
        public virtual ProcesType Procestype { get; set; }
        public virtual Afdeling Afdeling { get; set; }
        public virtual HoofdCode HoofdCode { get; set; }
        public virtual Unit Unit { get; set; }

        public virtual IList<Betrokkene> Betrokkenen { get; set; }
        public virtual IList<Klant> Klanten { get; set; }
        public virtual IList<Oorsprong> Oorsprongen { get; set; }
        public virtual IList<Bestemming> Bestemmingen { get; set; }
        public virtual IList<Locatie> Locaties { get; set; }
        public virtual IList<Soort> Soorten { get; set; }
        public virtual IList<Oorzaak> Oorzaken { get; set; }
        public virtual IList<Ca> Cas { get; set; }

        public void Afsluiten()
        {
            StatusRfEnum = EnumStatusRf.Afgesloten;
            AfwerkingsDatum = DateTime.Now.Date;
        }
    }
}