using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;


namespace Modelo
{
    public class DbBeca:DbContext
    {
        public DbSet<Beca> Becas { get; set; }
        public DbSet<DatosAcademicos> Datos { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
