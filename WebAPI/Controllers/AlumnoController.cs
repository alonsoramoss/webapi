using Domain;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly IAlumnoService _alumnoService;
        public AlumnoController(IAlumnoService alumnoService)
        {
            _alumnoService = alumnoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _alumnoService.ObtenerAlumnosAsync());
            //return await _alumnoService.ObtenerAlumnosAsync();
        }

        [HttpPost]
        [Route("GuardarAlumno")]
        public async Task<IActionResult> GuardarAlumno([FromBody] Alumno alumno)
        {
            await _alumnoService.guardarAlumno(alumno);
            return CreatedAtAction(nameof(Get), new { id = alumno.Id }, alumno);
        }

        [HttpPut]
        [Route("UpdateAlumno")]
        public async Task<IActionResult> UpdateAlumno([FromBody] Alumno alumno)
        {
            await _alumnoService.updateAlumno(alumno);
            return CreatedAtAction(nameof(Get), new { id = alumno.Id }, alumno);
        }

        [HttpDelete]
        [Route("DeleteAlumno")]
        public async Task<IActionResult> DeleteAlumno(int id)
        {
            await _alumnoService.deleteAlumno(id);
            return CreatedAtAction(nameof(Get), id);
        }
    }
}
