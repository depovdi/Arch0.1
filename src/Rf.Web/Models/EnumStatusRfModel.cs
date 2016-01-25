using System.ComponentModel.DataAnnotations;
namespace Rf.Web.Models
{
    public enum EnumStatusRfModel
    {
        [Display(Name = "Nieuw")]
        Nieuw = 0,
        [Display(Name = "Geregistreerd")]
        Geregistreerd = 1,
        [Display(Name = "Beantwoord")]
        Beantwoord = 2,
        [Display(Name = "Afgesloten")]
        Afgesloten = 3,
    }
}