using Envios_comercio.Models;
using Envios_comercio.Repositories.Dtos;

namespace Envios_comercio.Services.Interfaces
{
    public interface IEnvioService
    {
        List<EnvioDto> GetAllProducts();
        EnvioDto? GetProductById(int codigo);
        bool CreateProduct(CreateEnvioDto envioDto);
        bool UpdateProduct(UpdateEnvioDto envioDto);
        bool DeleteProduct(int codigo);
        bool SaveProduct(EnvioDto product);
        List<EnvioDto> GetActivos();
        List<EnvioDto> SearchByCostumer(string dni);

    }
}
