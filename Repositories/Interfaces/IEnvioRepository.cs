using Envios_comercio.Models;

namespace Envios_comercio.Repositories.Interfaces
{
    public interface IEnvioRepository
    {

        List<Envio> GetAll();
        Envio? GetById(int codigo);
        bool Create(Envio envio);
        bool Update(Envio envio);
        bool Delete(int codigo);
        bool Save(Envio envio);
    }
}
