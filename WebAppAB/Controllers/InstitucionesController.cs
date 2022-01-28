using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;

namespace WebAppAB.Controllers
{
    public class InstitucionesController : Controller
    {
        private readonly AprobacionBecaDB db;
        public InstitucionesController(AprobacionBecaDB db)
        {
            this.db = db;
        }

        // Listar Instituciones
        public IActionResult Index()
        {
            IEnumerable<Institucion> listaInstituciones = db.Instituciones;
            return View(listaInstituciones);
        }
        
        // Creación de Personas__________________________________
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Institucion institucion)
        {
            // Grabar la Instituciones
            db.Instituciones.Add(institucion);
            db.SaveChanges();

            TempData["mensaje"] = $"La Instituciones {institucion.Nombre} ha sido creada exitosamente";

            return RedirectToAction("Index");
        }

        // Para la Edición_________________________________________________________
        // Edicion de los Registros de la Institucion__________________________________

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Consulta a la instituciones por medio del Id
            Institucion institucion = db.Instituciones.Find(id);
            return View(institucion);
        }

        // Actualiza un registro 
        [HttpPost]
        public IActionResult Edit(Institucion institucion)
        {
            // Grabar la Institucion
            db.Instituciones.Add(institucion);
            db.SaveChanges();

            TempData["mensaje"] = $"La Institucion {institucion.Nombre} ha sido actualizada exitosamente";

            return RedirectToAction("Index");
        }

        // Boorado de Datos_________________________________________________________
        // Borrar de los Registros__________________________________

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Consulta a la persona por medio del Id
            Institucion institucion = db.Instituciones.Find(id);
            return View(institucion);
        }

        // Elimina un registro
        [HttpPost]
        public IActionResult Delete(Institucion institucion)
        {
            
            db.Instituciones.Remove(institucion);
            db.SaveChanges();

            TempData["mensaje"] = $"La Institucion {institucion.Nombre} ha sido eliminada";

            return RedirectToAction("Index");
        }
    }
}
