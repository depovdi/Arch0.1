using System.Collections.Generic;

namespace Rf.Domain
{
    public class Oorzaak
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public ICollection<Formulier> Formulieren { get; set; }
    }
}
