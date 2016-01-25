using System.ComponentModel.DataAnnotations;
namespace Rf.Web.Models
{
    public enum EnumBooleanModel
    {
        NoSelection = 0,
        [Display(Name = "Ja")]
        Yes = 1,
        [Display(Name = "Nee")]
        No = 2,
        [Display(Name = "Niet Gekend")]
        Unknown = 3
    }
}