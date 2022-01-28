using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;

namespace ModeloDB
{
    public class AprobacionBecaDB:DbContext
    {
        //Declaración de las entididades de Modelo
        public DbSet<Beca> Becas { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<CreditoBeca> Creditos { get; set; }
        public DbSet<Institucion> Instituciones { get; set; }
        public DbSet<OfertaBecas> Ofertas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<OfertaInstitucion> OfInst { get; set; }

        //Configuración de la Conexión.
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server = DESKTOP-IQ678RP\\SQLEXPRESS; initial catalog=ProyectoAprobacionBecas; trusted_connection=true;"
            );
        }

        //Configurar el modelo de objetos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuracion No tiene clave primaria
            modelBuilder.Entity<Configuracion>()
                .HasNoKey();

            modelBuilder.Entity<Beca>()
                .HasNoKey();

            //OfertasInstituciones

            //OfertasBecas
            modelBuilder.Entity<OfertaInstitucion>()
                .HasOne(oinstituciones => oinstituciones.Ofertas)
                .WithMany(ofertasbecas => ofertasbecas.OfertaInst)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(oinstituciones => oinstituciones.OfertaId);

            //Instituciones
            modelBuilder.Entity<OfertaInstitucion>()
                .HasOne(inst => inst.Ofertas)
                .WithMany(ofertasbecas => ofertasbecas.OfertaInst)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(inst => inst.OfertaId);

            // Relación uno a muchos; a un crédito pueden acceder varias Personas 
            modelBuilder.Entity<Persona>()
                .HasOne(persona => persona.CreditoBeca)
                .WithMany(credito => credito.Personas)
                .HasForeignKey(persona => persona.CreditoId);

            // Clave Primaria formada por dos claves foraneas.
            modelBuilder.Entity<OfertaInstitucion>()
                .HasKey(ofertaIns => new {
                    ofertaIns.InstitucionId,
                    ofertaIns.OfertaId});

            // Relación uno a muchos; a una Oferta de Becas pueden acceder varias Personas
            modelBuilder.Entity<Persona>()
                .HasOne(persona => persona.OfertaBeca)
                .WithMany(ofertaBecas => ofertaBecas.Personas)
                .HasForeignKey(persona => persona.OfertaId);

            // Relación uno a uno; un Reporte consta de una Solicitud
            modelBuilder.Entity<Reporte>()
                .HasOne(reporte => reporte.Solicitud)
                .WithOne(solicitud => solicitud.Reporte)
                .HasForeignKey<Solicitud>(solicitud => solicitud.ReporteId);

            // Relación uno a uno; una Persona puede realizar una Solicitud
            modelBuilder.Entity<Persona>()
                .HasOne(persona => persona.Solicitud)
                .WithOne(solicitud => solicitud.Persona)
                .HasForeignKey<Persona>(persona => persona.SolicitudId);

            // Relación uno a uno; una solicitud consta de un solo crédito
            modelBuilder.Entity<Solicitud>()
                .HasOne(solicitud => solicitud.Credito)
                .WithOne(credito => credito.Solicitud)
                .HasForeignKey<Solicitud>(solicitud => solicitud.CreditoId);
        }
    }
}
