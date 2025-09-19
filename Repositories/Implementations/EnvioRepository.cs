using Envios_comercio.Models;
using Envios_comercio.Repositories.Dtos;
using Envios_comercio.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Envios_comercio.Repositories.Implementations
{
    public class EnvioRepository : IEnvioRepository
    {
        private readonly Envio_comercioContext _context;

        public EnvioRepository(Envio_comercioContext context)
        {
            _context = context;
        }
        public bool Create(EnvioDto envio)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int codigo)
        {
            throw new NotImplementedException();
        }

        public List<EnvioDto> GetAll()
        {
            List<EnvioDto> enviosDto = new List<EnvioDto>();
            List<Envio> envios = _context.Envios.Include(e => e.DetallesEnvios).ToList();
            foreach (Envio e in envios)
            {
                EnvioDto enviodto = MapToDto(e);
                enviosDto.Add(enviodto);
            }
            return enviosDto;
        }

        public EnvioDto? GetById(int codigo)
        {
            throw new NotImplementedException();
        }

        public bool Save(EnvioDto envio)
        {
            throw new NotImplementedException();
        }

        public bool Update(EnvioDto envio)
        {
            throw new NotImplementedException();
        }

        public EnvioDto MapToDto(Envio envio)
        {
            EnvioDto dto = new EnvioDto();
            dto.Id = envio.Id;
            dto.Fecha = envio.Fecha;
            dto.Direccion = envio.Direccion;
            dto.Estado = envio.Estado;
            dto.DniCliente = envio.DniCliente;
            List<DetalleEnvioDto> detalles = new List<DetalleEnvioDto>();
            foreach (DetallesEnvio d in envio.DetallesEnvios)
            {
                DetalleEnvioDto detalleEnvioDto = new DetalleEnvioDto();
                Producto? producto = _context.Productos.Find(d.IdProducto);
                ProductoDto productoDto = new ProductoDto();
                productoDto.Precio = producto.Precio;
                productoDto.Nombre = producto.Nombre;
                detalleEnvioDto.productoDto = productoDto;
                detalleEnvioDto.Cantidad = d.Cantidad;
                detalleEnvioDto.Comentario = d.Comentario;
                detalles.Add(detalleEnvioDto);
            }
            dto.DetallesEnvios = detalles;
            return dto;
        }
    }
}
