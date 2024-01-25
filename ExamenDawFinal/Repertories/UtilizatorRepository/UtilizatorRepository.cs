using Examen.Repositories.GenericRepository;
using ExamenDawFinal.Data;
using Microsoft.EntityFrameworkCore;
using ExamenDawFinal.Model.Utilizator;
using Examen.Repositories.UtilizatorRepository;

namespace Examen.Repositories.ProdusRepository
{
    public class UtilizatorRepository : GenericRepository<utilizator>, IUtilizatorRepository
    {
        public UtilizatorRepository(ApplicationDbContext context) : base(context)
        {
        }

    }

}
