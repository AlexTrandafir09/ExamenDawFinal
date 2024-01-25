using AutoMapper;
using Examen.Repositories.ProdusRepository;
using ExamenDawFinal.Model.Produs;
using Microsoft.AspNetCore.Mvc;
namespace ExamenDawFinal.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ProdusController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProdusRepository _produsRepository;

        public ProdusController(IProdusRepository produsRepository, IMapper mapper) //declarare controller comenzi
        {
            _mapper = mapper;
            _produsRepository = produsRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<produs>> GetAllComenzi() //afisare comenzi
        {
            return await _produsRepository.GetAllAsync();
        }
        [HttpPost]
        public async Task CreateProdus(produs produs) //creare comanda
        {
            await _produsRepository.CreateAsync(produs);
            await _produsRepository.SaveAsync();
        }
    }
}
