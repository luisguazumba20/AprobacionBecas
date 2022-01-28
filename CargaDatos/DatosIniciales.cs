using System;
using System.Collections.Generic;
using Modelo.Entidades;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo
        {
            Personas, Creditos, Instituciones,
            Ofertas, Solicitudes, Reportes,
            Configuraciones
        }

        public Dictionary<ListasTipo, object> Carga()
        {

            // --------------------------------------------
            // Lista de Personas
            // --------------------------------------------
            #region
            Persona Persona1 = new Persona()
            {
                Nombres = "Juan Carlos",
                Apellidos = "Lara Pesantez",
                Cedula = "1724219926",
                Ciudad = "Sangolqui Valle de los Chillos",
                FechaNacimiento = new DateTime(1971, 5, 18),
                Telefono = "0986377625",
                Profesion = "Trabajador"
            };

            Persona Persona2 = new Persona()
            {
                Nombres = "Luis Felipe",
                Apellidos = "Carillo Lopez",
                Cedula = "17242178936",
                Ciudad = "El Tingo Valle de los Chillos",
                FechaNacimiento = new DateTime(1991, 5, 18),
                Telefono = "0922277625",
                Profesion = "Trabajador"
            };
            Persona Persona3 = new Persona()
            {
                Nombres = "Carlos David",
                Apellidos = "Carillo Ayala",
                Cedula = "172098789",
                Ciudad = "Valle de los Chillos",
                FechaNacimiento = new DateTime(1996, 12, 18),
                Telefono = "0922277625",
                Profesion = "Estudiante"
            };

            List<Persona> listaPersonas = new List<Persona>()
            {
                Persona1,Persona2,Persona3
            };
            #endregion
            // --------------------------------------------
            // Configuracion
            // --------------------------------------------
            #region
            Configuracion config = new Configuracion()
            {
                NombreUniversidad = "Universidad de Argentina",
                notaMinima = 7.0f,
                CompromisoPago = "Obligatorio",
                TiempoPago = 10,
                TiempoCarrera = "4 Años",
            };

            List<Configuracion> listaConfiguracion = new List<Configuracion>()
            {
                config
            };
            #endregion
            // --------------------------------------------
            // Lista de Creditos
            // --------------------------------------------
            #region
            CreditoBeca credito1 = new CreditoBeca()
            {
                CuotasMensuales=250.00,
                Intereses=45.50,
                Tiempo="10 Años",
                Estado="Pendiente",
                ValorCredito=10.000
            };

            CreditoBeca credito2 = new CreditoBeca()
            {
                CuotasMensuales = 450.00,
                Intereses = 65.50,
                Tiempo = "10 Años",
                Estado = "Pendiente",
                ValorCredito = 10.000
            };

            CreditoBeca credito3 = new CreditoBeca()
            {
                CuotasMensuales = 300.00,
                Intereses = 40.50,
                Tiempo = "10 Años",
                Estado = "Pendiente",
                ValorCredito = 10.000
            };

            List<CreditoBeca> listaCreditos = new List<CreditoBeca>()
            {
                credito1, credito2, credito3, 
            };
            #endregion
            // --------------------------------------------
            // Lista de Instituciones
            // --------------------------------------------
            #region
            Institucion inst1 = new Institucion()
            {
                Nombre="Universidad Regional",
                Tipo="Privada",
                Pais="México",
                Email="universidadregional@gmail.com"
            };

            Institucion inst2 = new Institucion()
            {
                Nombre = "Universidad Estatal",
                Tipo = "Privada",
                Pais = "Argentina",
                Email = "universidadestatal@gmail.com"
            };

            List<Institucion> listaInstituciones = new List<Institucion>()
            {
                inst1, inst2
            };
            #endregion
            // Solicitudes
            #region
            Solicitud solicitudLunes = new Solicitud()
            {
                FechaSolicitud = new DateTime(2022, 1, 18),
                DatosPersonales = "Luis Alfredo Guazumba",
                DatosAcademicos = "Estudios Aprobados",
                TipoBeca = "Credito Total"
            };
            Solicitud solicitudMartes = new Solicitud()
            {
                FechaSolicitud = new DateTime(2022, 1, 19),
                DatosPersonales = "Luis Ernesto Ayo",
                DatosAcademicos = "Estudios Aprobados",
                TipoBeca = "Credito Total"
            };
            
            List<Solicitud> listaSolicitudes = new List<Solicitud>()
            {
                solicitudLunes, solicitudMartes
            };
            #endregion

            // Reportes
            Reporte reporte1 = new Reporte()
            {
                FechaReporte = new DateTime(2022, 1, 25),
                Observacion = "Faltan Requisitos",
                Estado = "Pendiente"
            };

            Reporte reporte2 = new Reporte()
            {
                FechaReporte = new DateTime(2022, 1, 30),
                Observacion = "Faltan Requisitos",
                Estado = "Pendiente"
            };

            List<Reporte> listaReportes = new List<Reporte>()
            {
                reporte1, reporte2
            };

            // Lista de Ofertas
            OfertaBecas oferta1 = new OfertaBecas()
            {
                Costo = 10.000,
                Duracion = "4 años",
                Modalidad = "Presencial",
                FechaInicio = new DateTime(2022, 6, 10),
                TipoFinanciamiento = "Directo"
            };

            List<OfertaBecas> listaOfertas = new List<OfertaBecas>()
            {
                oferta1
            };


            // --------------------------------------------
            // Diccionario contiene todas las listas
            // --------------------------------------------
            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Personas, listaPersonas },
                { ListasTipo.Creditos, listaCreditos },
                { ListasTipo.Instituciones, listaInstituciones },
                { ListasTipo.Solicitudes, listaSolicitudes },
                { ListasTipo.Reportes, listaReportes},
                { ListasTipo.Ofertas,listaOfertas },
                { ListasTipo.Configuraciones, listaConfiguracion}
            };

            return dicListasDatos;
        }
    }
}
