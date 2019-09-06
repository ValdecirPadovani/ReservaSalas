using AutoMapper;
using ReservaSalas.DTO;
using ReservaSalas.Models;

namespace ReservaSalas.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Sala, SalaDTO>().ReverseMap();
            CreateMap<Reserva, ReservasDTO>().ReverseMap();
        }
    }
}
