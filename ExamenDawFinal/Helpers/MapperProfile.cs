using AutoMapper;
using ExamenDawFinal.Model.Comanda;
using ExamenDawFinal.Model.Comanda.DTO;
using ExamenDawFinal.Model.Utilizator;
using ExamenDawFinal.Model.Produs;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using ExamenDawFinal.Model.Produs.DTO;

namespace Examen.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<comanda, ComandaResponseDto>();
            CreateMap<ComandaRequestDto, comanda>();

            CreateMap<produs, ProdusResponseDto>();
            CreateMap<ProdusRequestDto, produs>();


            CreateMap<utilizator, ComandaResponseDto>();
            CreateMap<ComandaRequestDto, utilizator>();
        }
    }
}