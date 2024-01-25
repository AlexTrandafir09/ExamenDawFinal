using ExamenDawFinal.Model.Comanda;
using ExamenDawFinal.Model.Produs;
using ExamenDawFinal.Models.Base;
namespace ExamenDawFinal.Model.Comanda_Produs
{
    public class comanda_produs : BaseEntity
    {
        public produs Produs { get; set; }
        public comanda Comanda { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}
