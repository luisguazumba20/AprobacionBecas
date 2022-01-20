using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class OfertaBecas
    {
        public int OfertaId { get; set; }

        // Relación con la Institución
        public int InstitucionId { get; set; }
        public Institucion Institucion { get; set; }

        public string Duracion { get; set; }
        public string Modalidad { get; set; }
        public string FechaInicio { get; set; }
        public string TipoFinanciamiento { get; set; }
        public double Costo { get; set; }

        //Relación con Personas
        public List<Persona> Personas { get; set; }
    }
}
