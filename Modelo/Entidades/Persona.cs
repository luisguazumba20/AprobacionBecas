using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class Persona
    {
        public int PersonaId { get; set; }

        // Relación con el crédito
        public int CreditoId { get; set; }
        public CreditoBeca CreditoBeca { get; set; }

        // Relación con la Oferta
        public int OfertaId { get; set; }
        public OfertaBecas OfertaBeca { get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Profesion { get; set; }

        // Relación Uno a Uno
        public Solicitud Solicitud { get; set; }
    }
}
