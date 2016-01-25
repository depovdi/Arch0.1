using System.ComponentModel.DataAnnotations;

namespace Rf.Web.Models
{
    public enum EnumAuditTypeModel
    {
        NietsGeselecteerd = 0,
        [Display(Name = "InterneAudit")]
        InterneAudit = 1,
        [Display(Name = "ExterneAudit")]
        ExterneAudit = 2
    }
}