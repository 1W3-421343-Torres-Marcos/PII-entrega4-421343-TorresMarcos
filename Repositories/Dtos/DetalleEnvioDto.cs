using Envios_comercio.Models;

namespace Envios_comercio.Repositories.Dtos
{
    public class DetalleEnvioDto
    {
        public ProductoDto? productoDto { get; set; }
        public int Cantidad { get; set; }
        public string? Comentario { get; set; }
    }
}
