using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Solicitud
    {
        public int SolicitudId { get; set; }
        //Relacion de UNO A UNO
        public int ReporteId { get; set; }
        public Reporte Reporte { get; set; }
        //Relacion de UNO A UNO
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public DateTime FechaSolicitud { get; set; }
        public string DatosPersonales { get; set; }
        public string DatosAcademicos { get; set; }
        public string TipoBeca { get; set; }

        // Relación Uno a Uno
        public int CreditoId { get; set; }
        public CreditoBeca Credito { get; set; }

    }
}
