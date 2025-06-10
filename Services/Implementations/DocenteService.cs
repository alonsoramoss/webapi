using Domain;
using Infrastructure.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class DocenteService : IDocenteService
    {
        private readonly GenericRepository<Docente> _docenteRepo;

        public DocenteService(GenericRepository<Docente> docenteRepo)
        {
            _docenteRepo = docenteRepo;
        }

        public async Task<IEnumerable<Docente>> ObtenerDocentesAsync()
        {
            var docentes = await _docenteRepo.GetAllAsync();
            return docentes;
        }

        public async Task guardarDocente(Docente docente)
        {
            await _docenteRepo.AddAsync(docente);
        }

        public async Task updateDocente(Docente docente)
        {
            await _docenteRepo.UpdateAsync(docente);
        }

        public async Task deleteDocente(int id)
        {
            await _docenteRepo.DeleteAsync(id);
        }
    }
}