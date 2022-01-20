using System;
using System.Collections.Generic;
using System.Linq;


namespace Modelo.Entidades
{
    public class Institucion
    {
        public int InstitucionId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }

        //Relación con Ofertas
        public List<OfertaBecas> Ofertas { get; set; }

    }
}
