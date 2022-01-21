using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona NuevaPersona = new Persona()
            {
                Nombres = "Juan Carlos",
                Apellidos = "Lara Pesantez",
                Cedula = "1724219926",
                Ciudad = "Sangolqui Valle de los Chillos",
                //FechaNacimiento = "",
                Telefono = "0986377625",
                Profesion = "Trabajador"
            };

            Persona NuevaPersona2 = new Persona()
            {
                Nombres = "Luis Felipe",
                Apellidos = "Carillo Lopez",
                Cedula = "17242178936",
                Ciudad = "El Tingo Valle de los Chillos",
                //FechaNacimiento = '14-02-2022',
                Telefono = "0922277625",
                Profesion = "Trabajador"
            };

            Persona NuevaPersona3 = new Persona()
            {
                Nombres = "Carlos David",
                Apellidos = "Carillo Ayala",
                Cedula = "172098789",
                Ciudad = "El Tingo Valle de los Chillos",
                //FechaNacimiento = '14-02-2022',
                Telefono = "0922277625",
                Profesion = "Estudiante"
            };
        }
    }
}
