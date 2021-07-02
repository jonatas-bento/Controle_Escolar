using System;
using Microsoft.AspNetCore.Mvc;
namespace ControleEscolar_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurmaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok("Turma encontrada");
            }

            catch (Exception err)
            {

                return BadRequest($"Error:  {err.Message}");
            }
        }

    }
}