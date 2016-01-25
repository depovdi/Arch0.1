using System.Collections.Generic;

namespace Rf.Domain
{
    public class Soort
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Nummer { get; set; }

        public ICollection<Formulier> Formulieren { get; set; }
    }
}
