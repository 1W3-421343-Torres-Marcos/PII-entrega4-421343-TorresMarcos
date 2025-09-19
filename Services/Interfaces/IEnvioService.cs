using Envios_comercio.Models;
using Envios_comercio.Repositories.Dtos;

namespace Envios_comercio.Services.Interfaces
{
    public interface IEnvioService
    {
        List<EnvioDto> GetAllEnvios();
        EnvioDto? GetProductById(int codigo);
        bool CreateEnvio(CreateEnvioDto envioDto);
        bool UpdateEnvio(UpdateEnvioDto envioDto);
        bool DeleteEnvio(int codigo);
        bool SaveEnvio(EnvioDto product);
        List<EnvioDto> GetActivos();
        List<EnvioDto> SearchByCostumer(string dni);

    }
}
