using System;
using System.Collections.Generic;

namespace Modelo.Entidades
{
    public class OfertaInstitucion
    {
        public int InstitucionId { get; set; }
        public int OfertaId { get; set; }
        // Relaciones 
        public Institucion Institucion { get; set; }
        public OfertaBecas Ofertas { get; set; }
    }
}
