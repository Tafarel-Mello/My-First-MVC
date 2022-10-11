namespace LanchesDoTafa.Models
{
    public class SubLanche : Lanche
    {
        public string Acomp { get; set; }
        public string BebidaAcomp { get; set; }

        public SubLanche(string acomp, string bebidaAcomp)
        {
            Acomp = acomp;
            BebidaAcomp = bebidaAcomp;
        }

        public SubLanche()
        {
        }
    }
}
