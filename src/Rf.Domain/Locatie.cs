using System.Collections.Generic;

namespace Rf.Domain
{
    public class Locatie
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Afkorting { get; set; }

        public ICollection<Formulier> Formulieren { get; set; }
    }
}
