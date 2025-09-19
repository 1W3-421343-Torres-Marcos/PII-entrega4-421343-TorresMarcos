using Envios_comercio.Models;
using Envios_comercio.Repositories.Dtos;

namespace Envios_comercio.Repositories.Interfaces
{
    public interface IEnvioRepository
    {

        List<EnvioDto> GetAll();
        EnvioDto? GetById(int codigo);
        List<EnvioDto> GetActivos();
        bool Create(EnvioDto envio);
        bool Update(EnvioDto envio);
        bool Delete(int codigo);
        bool Save(EnvioDto envio);
    }
}
