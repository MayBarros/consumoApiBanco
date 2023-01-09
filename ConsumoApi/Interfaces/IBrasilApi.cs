using ConsumoApi.Dtos;
using ConsumoApi.Models;

namespace ConsumoApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco); 
    }
}