using System.ComponentModel.DataAnnotations;
namespace Rf.Web.Models
{
    public enum EnumOngevalTypeModel
    {
        NietsGeselecteerd = 0,
        [Display(Name = "Arbeidsongeval")]
        Arbeidsongeval = 1,
        [Display(Name = "Verkeersongeval")]
        Verkeersongeval = 2
    }
}