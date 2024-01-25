using AutoMapper;
using ExamenDawFinal.Model.Comanda;
using ExamenDawFinal.Repositories.ComandaRepository;
using Microsoft.AspNetCore.Mvc;
namespace ExamenDawFinal.Controllers {

    [Route("[controller]")]
    [ApiController]
    public class ComandaController :ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IComandaRepository _comandaRepository;

        public ComandaController(IComandaRepository comandaRepository, IMapper mapper) //declarare controller comenzi
        {
            _mapper = mapper;
            _comandaRepository = comandaRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<comanda>> GetAllComenzi() //afisare comenzi
        {
            return await _comandaRepository.GetAllAsync();
        }
        [HttpPost]
        public async Task CreateComanda(comanda comanda) //creare comanda
        {
            await _comandaRepository.CreateAsync(comanda);
            await _comandaRepository.SaveAsync();
        }
    }
}
