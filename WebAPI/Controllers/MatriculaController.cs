using Domain;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaService _matriculaService;

        public MatriculaController(IMatriculaService matriculaService)
        {
            _matriculaService = matriculaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _matriculaService.ObtenerMatriculasAsync());
        }

        [HttpPost]
        [Route("GuardarMatricula")]
        public async Task<IActionResult> GuardarMatricula([FromBody] Matricula matricula)
        {
            await _matriculaService.guardarMatricula(matricula);
            return CreatedAtAction(nameof(Get), new { id = matricula.Id }, matricula);
        }

        [HttpPut]
        [Route("UpdateMatricula")]
        public async Task<IActionResult> UpdateMatricula([FromBody] Matricula matricula)
        {
            await _matriculaService.updateMatricula(matricula);
            return CreatedAtAction(nameof(Get), new { id = matricula.Id }, matricula);
        }

        [HttpDelete]
        [Route("DeleteMatricula")]
        public async Task<IActionResult> DeleteMatricula(int id)
        {
            await _matriculaService.deleteMatricula(id);
            return CreatedAtAction(nameof(Get), id);
        }
    }
}