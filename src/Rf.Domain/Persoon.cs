namespace Rf.Domain
{
    public class Persoon
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public bool Manager { get; set; }

        public virtual Afdeling Afdeling { get; set; }
    }
}
