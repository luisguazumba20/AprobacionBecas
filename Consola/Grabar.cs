using CargaDatos;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using static CargaDatos.DatosIniciales;

namespace Consola
{
    public class Grabar
    {
        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            // Extraer del diccionario las listas
            var listaPersonas = (List<Persona>)listas[ListasTipo.Personas];
            var listaCreditos = (List<CreditoBeca>)listas[ListasTipo.Creditos];
            var listaInstituciones = (List<Institucion>)listas[ListasTipo.Instituciones];
            var listaSolicitudes = (List<Solicitud>)listas[ListasTipo.Solicitudes];
            var listaReportes = (List<Reporte>)listas[ListasTipo.Reportes];
            var listaConfiguraciones = (List<Configuracion>)listas[ListasTipo.Configuraciones];

            //Grabar
            AprobacionBecaDB db = new AprobacionBecaDB();

            db.Personas.AddRange(listaPersonas);
            db.Creditos.AddRange(listaCreditos);
            db.Institutuciones.AddRange(listaInstituciones);
            db.Solicitudes.AddRange(listaSolicitudes);
            db.Reportes.AddRange(listaReportes);
            db.Configuraciones.AddRange(listaConfiguraciones);

            db.SaveChanges();
        }
    }
}
