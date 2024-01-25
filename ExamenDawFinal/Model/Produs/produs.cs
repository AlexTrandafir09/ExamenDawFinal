using ExamenDawFinal.Model.Comanda_Produs;
using ExamenDawFinal.Models.Base;

namespace ExamenDawFinal.Model.Produs
{
    public class produs: BaseEntity
    {
        public string nume_produs { get; set; }

        public string tip_produs { get; set; }

        public ICollection<comanda_produs> Comanda_Produs { get; set; }
    }
}
