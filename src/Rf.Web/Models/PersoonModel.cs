using System.ComponentModel.DataAnnotations;
namespace Rf.Web.Models
{
    public class PersoonModel
    {
        public int Id { get; set; }
        public AfdelingModel Afdeling { get; set; }
        public string Naam { get; set; }
        public bool Manager { get; set; }
    }
}
