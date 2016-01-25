using System.Collections.Generic;

namespace Rf.Domain
{
    public class Oorsprong
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        public ICollection<Formulier> Formulieren { get; set; }
    }
}
