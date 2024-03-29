using AutoMapper;
using FLP.DashboardScanners.Aplicacion.DTO;
using FLP.DashboardScanners.Dominio.Entity;
using FLP.DashboardScanners.Domino.Entity;

namespace FPL.DashboardScanners.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile() 
        { 
            CreateMap<LecturaResponse, LecturaResponseDto>().ReverseMap();
            CreateMap<RatioDeErrorResponse, RatioDeErrorResponseDto>().ReverseMap()
                .ForMember(destination => destination.Desde, source => source.MapFrom(src => src.Desde))
                .ForMember(destination => destination.Hasta, source => source.MapFrom(src => src.Hasta))
                .ForMember(destination => destination.Dispositivo, source => source.MapFrom(src => src.Dispositivo))
                .ForMember(destination => destination.Ok, source => source.MapFrom(src => src.Ok))
                .ForMember(destination => destination.NoRead, source => source.MapFrom(src => src.NoRead));
            CreateMap<Dispositivo, DispositivoResponseDto>().ReverseMap();
            CreateMap<RastreoCajaResponse, RastreoCajaResponseDto>().ReverseMap();
        }
    }
}
