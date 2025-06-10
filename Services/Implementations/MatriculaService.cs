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
    public class MatriculaService : IMatriculaService
    {
        private readonly GenericRepository<Matricula> _matriculaRepo;

        public MatriculaService(GenericRepository<Matricula> matriculaRepo)
        {
            _matriculaRepo = matriculaRepo;
        }

        public async Task<IEnumerable<Matricula>> ObtenerMatriculasAsync()
        {
            var matriculas = await _matriculaRepo.GetAllAsync();
            return matriculas;
        }

        public async Task guardarMatricula(Matricula matricula)
        {
            await _matriculaRepo.AddAsync(matricula);
        }

        public async Task updateMatricula(Matricula matricula)
        {
            await _matriculaRepo.UpdateAsync(matricula);
        }

        public async Task deleteMatricula(int id)
        {
            await _matriculaRepo.DeleteAsync(id);
        }
    }
}