using Envios_comercio.Repositories.Dtos;
using Envios_comercio.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Envios_comercio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnvioController : Controller
    {
        private readonly IEnvioService _service;
        public EnvioController(IEnvioService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                return Ok(_service.GetAllEnvios());
            }
            catch (Exception)
            {
                return StatusCode(500, "error en servidor");
            }
            ;
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            try
            {
                return Ok(_service.GetEnvioById(id));
            }
            catch (Exception)
            {
                return StatusCode(500, "error en servidor");
            }
            ;
        }
        [HttpPost]
        public ActionResult Create(EnvioDto envio)
        {
            return View();
        }

        [HttpPut]
        public ActionResult Update(EnvioDto envio)
        {
            return View();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                return Ok(_service.DeleteEnvio(id));
            }
            catch (Exception)
            {
                return StatusCode(500, "error en servidor");
            }
            ;
        }

        [HttpGet("/active")]
        public ActionResult GetActive()
        {
            try
            {
                return Ok(_service.GetActivos());
            }
            catch (Exception)
            {
                return StatusCode(500, "error en servidor");
            }
            ;
        }

        [HttpGet("/search/{direccion}")]
        public ActionResult GetByDireccion(string direccion)
        {
            try
            {
                List<EnvioDto> envios = _service.GetActivos();
                List<EnvioDto> filtrado = new List<EnvioDto>();
                foreach (EnvioDto envio in envios)
                {
                    if (envio.Direccion != null && envio.Direccion.ToLower().Contains(direccion.ToLower()))
                    {
                        filtrado.Add(envio);
                    }
                }
                if(filtrado.Count < 1)
                {
                    return StatusCode(404, "no hay envios a esa direccion");
                }
                return Ok(filtrado);
            }
            catch (Exception)
            {
                return StatusCode(500, "error en servidor");
            }
            ;
        }
    }
}
