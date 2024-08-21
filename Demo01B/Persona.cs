using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Persona

    {
        public Persona()
        {

        }

        public Persona (string nombres, string apellidos)
        {
            Nombres = nombres;
            Apellidos = apellidos;
        }

        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }
        public String NombresCompletos { get; set; }

        public string DeolverEstado()
        {
            string mensaje = "Es menor de edad";
            if (Edad > 18)
                mensaje = "Es mayor de edad";
            return mensaje;
        }

        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }

    }
}
