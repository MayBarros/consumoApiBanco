using ConsumoApi.Dtos;
using ConsumoApi.Models;
using AutoMapper;


namespace ConsumoApi.Mapping
{
    public class BancoMapping : Profile
    {
        
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}