using Rf.Web.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Rf.Web.ViewModel
{
    public class RapporteringsFormulierViewModel
    {
        public RapporteringsFormulierViewModel()
        {
            SelectedOorzaakIds = Enumerable.Empty<int>().ToArray();
            SelectedKlantenIds = Enumerable.Empty<int>().ToArray();
            SelectedOorsprongIds = Enumerable.Empty<int>().ToArray();
            SelectedCaIds = Enumerable.Empty<int>().ToArray();
            SelectedBestemmingIds = Enumerable.Empty<int>().ToArray();
            SelectedLocatieIds = Enumerable.Empty<int>().ToArray();
            SelectedBetrokkeneIds = Enumerable.Empty<int>().ToArray();
            SelectedStatusRf = Enumerable.Empty<int>().ToArray();
        }

        public FormulierModel RapporteringsFormulier { get; set; }
        public ReferenceDataModel ReferenceData { get; set; }

        public int? SelectedOntvangerId { get; set; }

        [Required(ErrorMessage="Opsteller veld is verplicht en mag niet leeg zijn")]
        public int SelectedOpstellerId { get; set; }
        public int? SelectedOntvangerQLId { get; set; }
        public int? SelectedVoertuigId { get; set; }
        public int? SelectedKlachtSoortId { get; set; }
        public int[] SelectedOorzaakIds { get; set; }
        public int? SelectedDetailCodeId { get; set; }
        public int? SelectedHoofdCodeId { get; set; }
        public int[] SelectedKlantenIds { get; set; }
        public int? SelectedQualityProcedureId { get; set; }
        public int? SelectedUnitId { get; set; }
        public int[] SelectedOorsprongIds { get; set; }
        public int[] SelectedCaIds { get; set; }
        public int? SelectedAfdelingId { get; set; }
        public int[] SelectedBestemmingIds { get; set; }
        public int[] SelectedLocatieIds { get; set; }
        public int[] SelectedBetrokkeneIds { get; set; }
        public int? SelectedRpId { get; set; }
        public int[] SelectedStatusRf { get; set; }

    }
}