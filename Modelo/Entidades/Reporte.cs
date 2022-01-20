using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Reporte
    {
        public int ReporteId { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaReporte { get; set; }
        // Relación Uno a Uno
        public Solicitud Solicitud { get; set; }
    }
}
