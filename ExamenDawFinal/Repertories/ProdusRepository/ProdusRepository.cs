using Examen.Repositories.GenericRepository;
using ExamenDawFinal.Data;
using Microsoft.EntityFrameworkCore;
using ExamenDawFinal.Model.Produs;

namespace Examen.Repositories.ProdusRepository
{
    public class ProdusRepository : GenericRepository<produs>, IProdusRepository
    {
        public ProdusRepository(ApplicationDbContext context) : base(context)
        {
        }

    }

}
