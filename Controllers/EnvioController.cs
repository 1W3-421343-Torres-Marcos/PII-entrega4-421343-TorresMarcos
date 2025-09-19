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
            return View();
        }

        [HttpGet("/active")]
        public ActionResult GetActive()
        {
            return View();
        }

        [HttpGet("/search/{dni}")]
        public ActionResult GetByDni(string dni)
        {
            return View();
        }
    }
}
