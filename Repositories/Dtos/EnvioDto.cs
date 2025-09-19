using Envios_comercio.Models;

namespace Envios_comercio.Repositories.Dtos
{
    public class EnvioDto
    {
        public int Id { get; set; }
        public DateOnly Fecha { get; set; }
        public string? DniCliente { get; set; }
        public string? Direccion { get; set; }
        public string? Estado { get; set; }
        public List<DetalleEnvioDto> DetallesEnvios { get; set; } = new List<DetalleEnvioDto>();
    }

    public class CreateEnvioDto
    {
        public DateOnly Fecha { get; set; }
        public string? DniCliente { get; set; }
        public string? Direccion { get; set; }
        public List<DetalleEnvioDto> DetallesEnvios { get; set; } = new List<DetalleEnvioDto>();
    }

    public class UpdateEnvioDto
    {
        public int Id { get; set; }
        public DateOnly Fecha { get; set; }
        public string? DniCliente { get; set; }
        public string? Direccion { get; set; }
        public List<DetalleEnvioDto> DetallesEnvios { get; set; } = new List<DetalleEnvioDto>();
    }
}
