using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAlumnoService
    {
        Task<IEnumerable<Alumno>> ObtenerAlumnosAsync();

        Task guardarAlumno(Alumno alumno);

        Task updateAlumno(Alumno alumno);

        Task deleteAlumno(int id);
    }
}
