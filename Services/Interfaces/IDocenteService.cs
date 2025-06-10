using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDocenteService
    {
        Task<IEnumerable<Docente>> ObtenerDocentesAsync();

        Task guardarDocente(Docente docente);

        Task updateDocente(Docente docente);

        Task deleteDocente(int id);
    }
}