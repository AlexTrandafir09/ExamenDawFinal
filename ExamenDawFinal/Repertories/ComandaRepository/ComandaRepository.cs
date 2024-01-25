using ExamenDawFinal.Data;
using Microsoft.EntityFrameworkCore;
using ExamenDawFinal.Model.Comanda;
using ExamenDawFinal.Repositories.ComandaRepository;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.ComandaRepository
{
    public class ComandaRepository : GenericRepository<comanda>, IComandaRepository
    {
        public ComandaRepository(ApplicationDbContext context) : base(context)
        {
        }

    }

}
