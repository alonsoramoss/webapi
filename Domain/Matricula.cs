using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Matricula
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int AlumnoId { get; set; }
        public int DocenteId { get; set; }
        public bool Enabled { get; set; }
    }
}
