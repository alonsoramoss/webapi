using Domain;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        private readonly IDocenteService _docenteService;

        public DocenteController(IDocenteService docenteService)
        {
            _docenteService = docenteService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _docenteService.ObtenerDocentesAsync());
        }

        [HttpPost]
        [Route("GuardarDocente")]
        public async Task<IActionResult> GuardarDocente([FromBody] Docente docente)
        {
            await _docenteService.guardarDocente(docente);
            return CreatedAtAction(nameof(Get), new { id = docente.Id }, docente);
        }

        [HttpPut]
        [Route("UpdateDocente")]
        public async Task<IActionResult> UpdateDocente([FromBody] Docente docente)
        {
            await _docenteService.updateDocente(docente);
            return CreatedAtAction(nameof(Get), new { id = docente.Id }, docente);
        }

        [HttpDelete]
        [Route("DeleteDocente")]
        public async Task<IActionResult> DeleteDocente(int id)
        {
            await _docenteService.deleteDocente(id);
            return CreatedAtAction(nameof(Get), id);
        }
    }
}