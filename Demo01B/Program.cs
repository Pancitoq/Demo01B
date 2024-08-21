using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangulo triangulo = new Triangulo();
            triangulo.Altura = 4;
            triangulo.Base = 5;

            Persona persona = new Persona();
            persona.Nombres = "Ragde Luis";
            persona.Apellidos = "Melendez Cora";

            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);

            Persona persona1 = new Persona("Jesus", "Cora");

            Persona persona2 = new Persona
            {
                Nombres = "Derek",
                Apellidos = "Torrico",
                Edad = 5
            };

            Console.WriteLine(triangulo.CalcularArea())
            Console.WriteLine("Hola mundo");
            Console.Read();
        }
    }
}
