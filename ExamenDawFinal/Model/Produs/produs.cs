using ExamenDawFinal.Models.Base;

namespace ExamenDawFinal.Model.Produs
{
    public class produs
    {
        public string nume_produs { get; set; }

        public string tip_produs { get; set; }

        public ICollection<comanda_produs> comanda_Produs { get; set; }
    }
}
