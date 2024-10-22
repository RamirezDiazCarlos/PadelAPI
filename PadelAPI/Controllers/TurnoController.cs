using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PadelAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurnoController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerTurnosPredefinidos()
        {
            var turnos = TurnoPredefinido.ObtenerTurnosPredefinidos();
            return Ok(turnos);
        }

    }
}
