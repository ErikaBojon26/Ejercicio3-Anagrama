using Microsoft.AspNetCore.Mvc;
using Anagrama.Entities;
using System;
using System.Linq;
namespace Anagrama.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PalabrasController:ControllerBase
     {
         [HttpPost]
        public string comprueba( Palabras palabra)

        {
            string Palabra1 = "Si es un anagrama";
            string Palabra2 = "No es un anagrama";
            string Palabraori = String.Concat(palabra.Palabraorginal.OrderBy(c=>c));
            string palabranue= String.Concat(palabra.Palaabranueva.OrderBy(c=>c));

            if (Palabraori == palabranue)

            {

                return Palabra1;

            }

            else

            {

                return Palabra2;

            }

        }

    }

}
/* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 1, Ejercicio 3: Anagrama
    Nombre del alumno: Erika Guadalupe Bojon Martinez 
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */