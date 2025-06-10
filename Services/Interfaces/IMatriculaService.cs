using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IMatriculaService
    {
        Task<IEnumerable<Matricula>> ObtenerMatriculasAsync();

        Task guardarMatricula(Matricula matricula);

        Task updateMatricula(Matricula matricula);

        Task deleteMatricula(int id);
    }
}