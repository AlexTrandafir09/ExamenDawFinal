using AutoMapper;
using Examen.Repositories.UtilizatorRepository;
using ExamenDawFinal.Model.Utilizator;
using Microsoft.AspNetCore.Mvc;
namespace ExamenDawFinal.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class UtilizatorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUtilizatorRepository _utilizatorRepository;

        public UtilizatorController(IUtilizatorRepository utilizatorRepository, IMapper mapper)
        {
            _mapper = mapper;
            _utilizatorRepository = utilizatorRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<utilizator>> GetAllUtilizatori()
        {
            return await _utilizatorRepository.GetAllAsync();
        }
        [HttpPost]
        public async Task CreateComanda(utilizator utilizator) //creare comanda
        {
            await _utilizatorRepository.CreateAsync(utilizator);
            await _utilizatorRepository.SaveAsync();
        }
    }
}
