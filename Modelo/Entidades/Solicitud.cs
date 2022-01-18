using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public string Admitidos  { get; set; }
        public string Becados { get; set; }
        public string Espera { get; set; }
        public ICollection<Estudiante> Lista { get; set; }

    }
}
