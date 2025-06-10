using Domain;
using Infrastructure.Repositories;
using Services.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class AlumnoService : IAlumnoService
    {
        private readonly GenericRepository<Alumno> _alumnoRepo;

        public AlumnoService(GenericRepository<Alumno> alumnoRepo)
        {
            _alumnoRepo = alumnoRepo;
        }

        public async Task<IEnumerable<Alumno>> ObtenerAlumnosAsync()
        {
            var alumnos = await _alumnoRepo.GetAllAsync();
            return alumnos;
        }

        public async Task guardarAlumno(Alumno alumno)
        {
            await _alumnoRepo.AddAsync(alumno);
        }

        public async Task updateAlumno(Alumno alumno)
        {
            await _alumnoRepo.UpdateAsync(alumno);
        }

        public async Task deleteAlumno(int id)
        {
            await _alumnoRepo.DeleteAsync(id);
        }
    }
}
