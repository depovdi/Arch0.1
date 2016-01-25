using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rf.Web.Models
{
    public class ReferenceDataModel
    {
        public ReferenceDataModel()
        {
            Personen = new List<PersoonModel>();
            Voertuigen = new List<VoertuigModel>();
            KlachtSoorten = new List<SoortKlachtModel>();
            Oorsprongen = new List<OorsprongModel>();
            Oorzaken = new List<OorzaakModel>();
            DetailCodes = new List<DetailCodeModel>();
            HoofdCodes = new List<HoofdCodeModel>();
            Klanten = new List<KlantModel>();
            QualityProcedures = new List<QualityProcedureModel>();
            Units = new List<UnitModel>();
            Afdelingen = new List<AfdelingModel>();
            Cas = new List<CaModel>();
            Bestemmingen = new List<BestemmingModel>();
            Locaties = new List<LocatieModel>();
            Betrokkenen = new List<BetrokkeneModel>();
            Rps = new List<RpModel>();
        }

        public List<PersoonModel> Personen { get; set; }
        public List<VoertuigModel> Voertuigen { get; set; }
        public List<SoortKlachtModel> KlachtSoorten { get; set; }
        public List<OorzaakModel> Oorzaken { get; set; }
        public List<DetailCodeModel> DetailCodes { get; set; }
        public List<HoofdCodeModel> HoofdCodes { get; set; }
        public List<KlantModel> Klanten { get; set; }
        public List<QualityProcedureModel> QualityProcedures { get; set; }
        public List<UnitModel> Units { get; set; }
        public List<OorsprongModel> Oorsprongen { get; set; }
	    public List<AfdelingModel> Afdelingen { get; set; }
        public List<CaModel> Cas { get; set; }
        public List<BestemmingModel> Bestemmingen { get; set; }
        public List<LocatieModel> Locaties { get; set; }
        public List<BetrokkeneModel> Betrokkenen { get; set; }
        public List<RpModel> Rps { get; set; }
    }
}