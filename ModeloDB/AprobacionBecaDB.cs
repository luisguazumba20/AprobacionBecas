using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;

namespace ModeloDB
{
    public class AprobacionBecaDB : DbContext
    {
        //Declaración de las entididades de Modelo
        public DbSet<Beca> Becas { get; set; }
        public DbSet<DatosAcademicos> Datos { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }

        //Configuración de la Conexión.
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server = DESKTOP-IQ678RP\\SQLEXPRESS; initial catalog=AprobacionBecas; trusted_connection=true;"
            );
        }
    }
}
