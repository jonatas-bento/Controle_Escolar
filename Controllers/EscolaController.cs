using System;
using Microsoft.AspNetCore.Mvc;
namespace ControleEscolar_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EscolaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok("Escola encontrada");
            }

            catch (Exception err)
            {

                return BadRequest($"Error:  {err.Message}");
            }

        }
    }
}