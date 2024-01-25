using ExamenDawFinal.Models.Base;
using ExamenDawFinal.Model.Comanda;

namespace ExamenDawFinal.Model.Utilizator
{
    public class utilizator : BaseEntity
    {
        public string Nume_utilizator { get; set; }

        public ICollection<comanda> Comenzi {  get; set; } 
    }
}
