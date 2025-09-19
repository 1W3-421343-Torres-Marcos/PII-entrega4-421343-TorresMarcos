using Envios_comercio.Repositories.Dtos;
using Envios_comercio.Repositories.Interfaces;
using Envios_comercio.Services.Interfaces;
using System.Collections.Generic;

namespace Envios_comercio.Services.Implementations
{
    public class EnvioService : IEnvioService
    {
        private readonly IEnvioRepository _repository;

        public EnvioService(IEnvioRepository repository)
        {
            _repository = repository;
        }
        public bool CreateEnvio(CreateEnvioDto envioDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEnvio(int codigo)
        {
            throw new NotImplementedException();
        }

        public List<EnvioDto> GetActivos()
        {
            return _repository.GetActivos();
        }

        public List<EnvioDto> GetAllEnvios()
        {
            return _repository.GetAll();
        }

        public EnvioDto? GetEnvioById(int codigo)
        {
            return _repository.GetById(codigo);
        }

        public bool SaveEnvio(EnvioDto product)
        {
            throw new NotImplementedException();
        }

        public List<EnvioDto> SearchByCostumer(string dni)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEnvio(UpdateEnvioDto envioDto)
        {
            throw new NotImplementedException();
        }
    }
}
