using System.ComponentModel.DataAnnotations;
namespace Rf.Web.Models
{
    public class AfdelingModel
    {
        public int Id { get; set; }
        public string Afkorting { get; set; }
        public string Naam { get; set; }
        public string Manager { get; set; }
    }
}
