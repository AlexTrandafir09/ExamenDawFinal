using ExamenDawFinal.Model.Comanda_Produs;
using ExamenDawFinal.Models.Base;
using ExamenDawFinal.Model.Utilizator;

namespace ExamenDawFinal.Model.Comanda
{
    public class comanda : BaseEntity
    {
        bool cu_card {  get; set; }

        public utilizator Utilizator { get; set; }
        public ICollection<comanda_produs> Comanda_Produs { get; set; }

    }
}
