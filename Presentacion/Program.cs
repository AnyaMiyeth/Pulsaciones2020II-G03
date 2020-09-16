using System;
using System.Collections.Generic;
using Entity;
using BLL;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            string sexo;
            string identificacion;
            decimal pulsacion;


            Console.WriteLine("Digite la identificacion");
            identificacion = Console.ReadLine();

            Console.WriteLine("Digite el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite el sexo F/M:");
            sexo = Console.ReadLine();

            Console.WriteLine("Digite la edad");
            edad = int.Parse(Console.ReadLine());

            Persona persona = new Persona(identificacion,nombre,edad,sexo);
      

            PersonaService personaService = new PersonaService();

            persona.Pulsacion = personaService.CalcularPulsacion(sexo,edad);
            Console.WriteLine($"Su Pulsaciones {persona.Pulsacion} ");

            Console.WriteLine(personaService.Guardar(persona));

            Console.ReadKey();
           

        }
    }
}
