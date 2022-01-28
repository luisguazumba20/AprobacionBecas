using System;
using System.Collections.Generic;

namespace Modelo.Entidades
{
    public class CreditoBeca
    {
        public int CreditoId { get; set; }

        //Relacion de UNO A UNO
        public int SolicitudId { get; set; }
        public Solicitud Solicitud { get; set; }

        public double ValorCredito { get; set; }
        public double Intereses { get; set; }
        public double CuotasMensuales { get; set; }
        public string Tiempo { get; set; }
        public string Estado { get; set; }

        // Relación con Personas
        public List<Persona> Personas { get; set; }
    }
}
