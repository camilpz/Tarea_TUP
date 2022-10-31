using CarpinteriaApp.dominio;
using DataAPI.fachada;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiCarpinteria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestoController : ControllerBase
    {
        private IDataApi dataApi; //punto de acceso a la API

        public PresupuestoController()
        {
            dataApi = new DataApiImp();
        }

        [HttpGet("/productos")]
        public IActionResult GetProductos()
        {
            List<Producto> lst = null;
            try
            {
                lst = dataApi.GetProductos();
                return Ok(lst);

            }
            catch (Exception ex) {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPost("/presupuesto")]
        public IActionResult PostPresupuesto(Presupuesto presupuesto)
        {
            try
            {
                if(presupuesto == null)
                {
                    return BadRequest("Datos de presupuesto incorrectos!");
                }

                return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(dataApi.SavePresupuesto(presupuesto)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpDelete("/presupuesto")]

        public IActionResult DelPresupuesto(int id_presupuestp)
        {
            try
            {
                if(id_presupuestp == 0)
                {
                    return BadRequest("ID del presupuesto incorrecto");
                }
                return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(dataApi.DelPresupuesto(id_presupuestp)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno");
            }
        }

        [HttpPut("/presupuesto")]

        public IActionResult ActuPresupuesto(Presupuesto presupuesto)
        {
            try
            {
                if (presupuesto == null)
                {
                    return BadRequest("Datos del presupuesto incorrectos");
                }
                return Ok(dataApi.ActuPresupuesto(presupuesto)); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno, intente más tarde");
            }
            
        }
    }
}
