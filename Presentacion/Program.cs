using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (sexo.ToUpper().Equals("F"))
            {
                pulsacion = (220 - edad) / 10;
            }
            else if (sexo.ToUpper().Equals("M"))
            {
                pulsacion = (210 - edad) / 10;
            }
            else
            {
                pulsacion = 0;
            }

            Console.WriteLine($"Su Pulsaciones {pulsacion} " );

        }
    }
}
