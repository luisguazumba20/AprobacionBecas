using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;

namespace WebAppAB.Controllers
{
    public class PersonasController : Controller
    {
        private readonly AprobacionBecaDB db;
        public PersonasController(AprobacionBecaDB db)
        {
            this.db = db;
        }

        //Listar Personas
        public IActionResult Index()
        {
            IEnumerable<Persona> listaPersonas = db.Personas;
            return View(listaPersonas);
        }

        // Creación de Personas__________________________________
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Persona persona)
        {
            // Grabar la persona
            db.Personas.Add(persona);
            db.SaveChanges();

            TempData["mensaje"] = $"El usuario {persona.Nombres} {persona.Apellidos} ha sido creado exitosamente";

            return RedirectToAction("Index");
        }

        // Para la Edición_________________________________________________________
        // Edicion de los Registros de la Persona__________________________________

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Consulta a la persona por medio del Id
            Persona persona = db.Personas.Find(id);
            return View(persona);
        }

        // Actualiza un registro de una persona
        [HttpPost]
        public IActionResult Edit(Persona persona)
        {
            // Grabar la persona
            db.Personas.Add(persona);
            db.SaveChanges();

            TempData["mensaje"] = $"El usuario {persona.Nombres} {persona.Apellidos} ha sido actualizado exitosamente";

            return RedirectToAction("Index");
        }

        // Boorado de Datos_________________________________________________________
        // Borrar de los Registros de la Persona--__________________________________

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Consulta a la persona por medio del Id
            Persona persona = db.Personas.Find(id);
            return View(persona);
        }

        // Elimina un registro de una persona
        [HttpPost]
        public IActionResult Delete(Persona persona)
        {
            // Grabar la persona
            db.Personas.Remove(persona);
            db.SaveChanges();

            TempData["mensaje"] = $"El usuario {persona.Nombres} {persona.Apellidos} ha sido eliminado";

            return RedirectToAction("Index");
        }
    }
}
