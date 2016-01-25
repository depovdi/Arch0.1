using System.ComponentModel.DataAnnotations;

namespace Rf.Web.Models
{
    public enum EnumDossierTypeModel
    {
        NietsGeselecteerd = 0,
        [Display(Name = "Import")]
        Import = 1,
        [Display(Name = "Export")]
        Export = 2,
        [Display(Name = "Andere")]
        Andere = 3
    }
}